using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormularioDinamico.Models
{
    public class Encuesta
    {
        public int EncuestaId { get; set; }
        public string Title { get; set; }
        public List<EncuestaDetail> Questions { get; set; }

    }

    public class EncuestaDetail
    {
        
        public int EncuestaDetailId { get; set; }
        public string Question { get; set; }
        public List<Respuesta> Respuestas { get; set; }
    }

    public class Respuesta
    {
        public int RespuestaId { get; set; }
        public string Comentario { get; set; }
        public string Tipo { get; set; }
    }

    public static class DataEncuesta
    {

        public static Encuesta DataInformation()
        {
            Encuesta encuesta = new Encuesta();
            encuesta.EncuestaId = 1;
            encuesta.Title = "Madera verde";
            encuesta.Questions = new List<EncuestaDetail>
            {
                new EncuestaDetail
                {
                    EncuestaDetailId = 1,
                    Question  ="Cal fue el resultado Esperado ",
                    Respuestas = new List<Respuesta>
                    {
                        new Respuesta
                        {
                            Tipo = "Entry",
                            Comentario  = "SI",
                            RespuestaId = 1
                        },
                         new Respuesta
                        {
                             Tipo = "Check",
                            Comentario  = "NO",
                            RespuestaId = 1
                        }
                    }
                },
                new EncuestaDetail
                {
                    EncuestaDetailId = 2,
                    Question  ="Cual es el idolo del Ecuador",
                    Respuestas = new List<Respuesta>
                    {
                        new Respuesta
                        {
                            Comentario  = "Barcelona",
                            Tipo = "Entry",
                            RespuestaId = 1
                        },
                         new Respuesta
                        {
                            Comentario  = "Emelec",
                            Tipo  = "Entry",
                            RespuestaId = 1
                        }
                    }
                }
            };



            return encuesta;
        }
    }

}
