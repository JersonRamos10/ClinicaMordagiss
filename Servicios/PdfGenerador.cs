using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms.VisualStyles;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec.wmf;
using SistemaDeCitasMordagiss.Models;  // Para usar “Cita”, “Paciente”, etc. si lo necesitas

namespace SistemaDeCitasMordagiss.Servicios
{

    public static class PdfGenerator
    {

        public static void GenerarBoletaPdf(
            string rutaDestino,
            string pacienteNombre,
            string pacienteApellidos,
            string medicoNombre,
            DateTime fechaCita,
            string horaInicio,
            string horaFin)
        {

            using var fs = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write, FileShare.None);
            using var documento = new Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter.GetInstance(documento, fs);
            documento.Open();

            //  fuentes
            var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            var fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 12);

            // Titulo 
            var titulo = new Paragraph("---------BOLETA DE CITA MEDICA---------", fuenteTitulo)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 20f
            };
            documento.Add(titulo);

            // Datos del paciente
            var datosPaciente = new Paragraph(
                $"Paciente: {pacienteNombre} {pacienteApellidos}", fuenteNormal)
            {
                SpacingAfter = 10f
            };
            documento.Add(datosPaciente);

            //  Datos del medico
            var datosMedico = new Paragraph($"Médico: Dr/lic. {medicoNombre}", fuenteNormal)
            {
                SpacingAfter = 10f
            };
            documento.Add(datosMedico);

            // Fecha de la cita
            string fechaTexto = fechaCita.ToString("dddd, dd MMMM yyyy");
            var datosFecha = new Paragraph($"Fecha de la cita: {fechaTexto}", fuenteNormal)
            {
                SpacingAfter = 10f
            };
            documento.Add(datosFecha);

            // Hora de inicio y fin
            var datosHora = new Paragraph($"Hora: {horaInicio} – {horaFin}", fuenteNormal)
            {
                SpacingAfter = 20f
            };
            documento.Add(datosHora);

            //  Nota final
            var nota = new Paragraph(
                "Presentar esta boleta en recepción 10 minutos antes de la hora programada.",
                fuenteNormal)
            {
                SpacingBefore = 20f
            };
            documento.Add(nota);

            documento.Close();
        }


        public static void GenerarYMostrarBoletaPdf(
            string pacienteNombre,
            string pacienteApellidos,
            string medicoNombre,
            DateTime fechaCita,
            string horaInicio,
            string horaFin)
        {
            // Crear un nombre de archivo unico en la carpeta temporal
            string carpetaTemp = Path.GetTempPath();
            string nombreTemp = $"Boleta_{pacienteNombre}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string rutaTemp = Path.Combine(carpetaTemp, nombreTemp);

            // Generar el PDF en la ruta temporal
            GenerarBoletaPdf(rutaTemp, pacienteNombre, pacienteApellidos, medicoNombre, fechaCita, horaInicio, horaFin);

            // Abrir el PDF con la aplicación predeterminada de Windows
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = rutaTemp,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        public static void GenerarReporteCitasPdf(
            string rutaDestino,
            List<CitaGestionVista> citas,
            string infoPeriodo,
            string infoProfesional,
            string infoServicio)
        {
            //  Configuracion del documento
            using var fs = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write, FileShare.None);
            using var documento = new Document(PageSize.A4.Rotate(), 25, 25, 30, 30); // Pagina horizontal
            PdfWriter.GetInstance(documento, fs);
            documento.Open();

            // fuentes
            var fontTituloReporte = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            var fontInfoFiltros = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.DARK_GRAY);
            var fontEncabezadoTabla = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.WHITE);
            var fontCeldaTabla = FontFactory.GetFont(FontFactory.HELVETICA, 8, BaseColor.BLACK);

            // Titulo del Reporte e informacion de filtros
            documento.Add(new Paragraph("Reporte Detallado de Citas", fontTituloReporte) { Alignment = Element.ALIGN_CENTER });
            documento.Add(new Paragraph(infoPeriodo, fontInfoFiltros) { Alignment = Element.ALIGN_CENTER });
            documento.Add(new Paragraph(infoProfesional, fontInfoFiltros) { Alignment = Element.ALIGN_CENTER });
            documento.Add(new Paragraph(infoServicio, fontInfoFiltros) { Alignment = Element.ALIGN_CENTER });
            documento.Add(Chunk.NEWLINE); // Espacio antes de la tabla

            // Crear la tabla del PDF
            PdfPTable tablaPdf = new PdfPTable(6); // 6 columnas: Fecha, Hora, Paciente, Profesional, Servicio, Estado
            tablaPdf.WidthPercentage = 100;
            tablaPdf.SetWidths(new float[] { 12f, 8f, 25f, 25f, 15f, 15f });

            // Encabezados de la tabla
            string[] encabezados = { "Fecha", "Hora", "Paciente", "Profesional", "Servicio", "Estado" };
            foreach (string encabezado in encabezados)
            {
                PdfPCell celdaEncabezado = new PdfPCell(new Phrase(encabezado, fontEncabezadoTabla));
                celdaEncabezado.BackgroundColor = new BaseColor(45, 75, 115); // Un azul oscuro
                celdaEncabezado.HorizontalAlignment = Element.ALIGN_CENTER;
                celdaEncabezado.VerticalAlignment = Element.ALIGN_MIDDLE;
                celdaEncabezado.Padding = 5;
                tablaPdf.AddCell(celdaEncabezado);
            }

            // Anadir los datos de las citas a la tabla
            foreach (var cita in citas)
            {
                tablaPdf.AddCell(new Phrase(cita.FechaCita, fontCeldaTabla));
                tablaPdf.AddCell(new Phrase(cita.HoraInicio, fontCeldaTabla));
                tablaPdf.AddCell(new Phrase(cita.NombrePaciente, fontCeldaTabla));
                tablaPdf.AddCell(new Phrase(cita.NombreProfesional, fontCeldaTabla));
                tablaPdf.AddCell(new Phrase(cita.NombreServicio, fontCeldaTabla));
                tablaPdf.AddCell(new Phrase(cita.EstadoCita, fontCeldaTabla));
            }

            documento.Add(tablaPdf);
            documento.Close();
        }

        public static bool GenerarEImprimirReporte(
            List<CitaGestionVista> citas,
            string infoPeriodo,
            string infoProfesional,
            string infoServicio)
        {
            try
            {
             
                string carpetaTemp = Path.GetTempPath();
                string nombreTemp = $"ReporteCitasParaImprimir_{Guid.NewGuid()}.pdf";
                string rutaTemp = Path.Combine(carpetaTemp, nombreTemp);

               
                GenerarReporteCitasPdf(rutaTemp, citas, infoPeriodo, infoProfesional, infoServicio);

              
                Process procesoImpresion = new Process();
                procesoImpresion.StartInfo.FileName = rutaTemp;
              
                procesoImpresion.StartInfo.Verb = "Print";
                procesoImpresion.StartInfo.CreateNoWindow = true;
                procesoImpresion.StartInfo.UseShellExecute = true;

               
                return procesoImpresion.Start();
            }
            catch (Exception)
            {
               
                return false;
            }
        }
    }
}


