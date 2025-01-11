using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Refrigerantes.ModelDTO;
using System.Diagnostics;
using Refrigerantes.Services;

namespace Refrigerantes.Utils
{
    public class Notificaciones
    {
        private const string SERVIDOR = "smtp.gmail.com";
        private const int PUERTO = 587;
        private const string PASSWORD = "ovid uwff sptg pirj";
        private const string CORREO_GESTOR_REFRIGERANTES = "carlos.climatizacion@gmail.com";
        private List<InstalacionDTO> instalacionesEnRiesgo;
        private List<OperacionDeCargaDTO> operaciones;
        private List<EquipoDTO> equipos;

        public Notificaciones(List<InstalacionDTO> instalacionesEnRiesgo ,List<OperacionDeCargaDTO> operaciones)
        {
            this.instalacionesEnRiesgo = instalacionesEnRiesgo;
            this.operaciones = operaciones;
            CargarEquipos();
        }

        public void EnviarNotificaciones()
        {
            //EnviarPrueba();
            foreach (InstalacionDTO ins in instalacionesEnRiesgo)
            {
                string nombreCliente = ins.Cliente_DTO.Nombre;
                string nombreInstalacion = ins.Nombre_DTO;
                string emailCliente = ins.Cliente_DTO.Email;
                string asunto = CrearAsunto(nombreInstalacion);
                string cuerpo = CrearCuerpo(nombreCliente, nombreInstalacion);

                if (!string.IsNullOrEmpty(emailCliente))
                {
                    try
                    {
                        EnviarCorreo(emailCliente, asunto, cuerpo);
                        Console.WriteLine($"Notificación enviada a: {nombreCliente} ({emailCliente})");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al enviar notificación a {nombreCliente}: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"El cliente {nombreCliente} no tiene un correo electrónico válido.");
                }
            }
        }

        private void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            using (var mail = new MailMessage())
            {
                mail.From = new MailAddress(CORREO_GESTOR_REFRIGERANTES);
                mail.To.Add(destinatario);
                mail.Subject = asunto;
                mail.Body = cuerpo;
                mail.IsBodyHtml = false; // Cambiar a false si no quieres HTML en el correo

                using (var smtp = new SmtpClient(SERVIDOR, PUERTO))
                {
                    smtp.Credentials = new NetworkCredential(CORREO_GESTOR_REFRIGERANTES, PASSWORD);
                    smtp.EnableSsl = true; // Asegúrate de que tu servidor SMTP requiera SSL
                    smtp.Send(mail);
                }
            }
        }

        private string CrearAsunto(string instalacion)
        {
            string asunto = $"Su instalacion {instalacion} " +
                $"se encuentra en riesgo. ";

            return asunto;
        }

        private string CrearCuerpo(string cliente,string instalacion)
        {
            string cuerpo = $"Estimado cliente {cliente} . Su instalacion {instalacion} " +
                $"se encuentra en riesgo. Nos ponemos en contacto con usted para informarle de este hecho, quedamos  " +
                $"a la espera de respuesta, atentamente el equipo de GESTOR DE REFRIGERANTES.";

            return cuerpo;
        }

        private void EnviarPrueba()
        {
            string nombreCliente = "Prueba Cliente";
            string nombreInstalacion = "Prueba Cliente";
            string emailCliente = "carlos.climatizacion@gmail.com";
            string asunto = "prueba mails";
            string cuerpo = "prueba mails";

            if (!string.IsNullOrEmpty(emailCliente))
            {
                try
                {
                    EnviarCorreo(emailCliente, asunto, cuerpo);
                    Debug.WriteLine($"Notificación enviada a: {nombreCliente} ({emailCliente})");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error al enviar notificación a {nombreCliente}: {ex.Message}");
                }
            }
            else
            {
                Debug.WriteLine($"El cliente {nombreCliente} no tiene un correo electrónico válido.");
            }
        }

        private async Task CargarEquipos() 
        {
            using (var context = new EquipoADO())
            {
                equipos = context.ListarEquipos(); 
            }
        }

    }

}
