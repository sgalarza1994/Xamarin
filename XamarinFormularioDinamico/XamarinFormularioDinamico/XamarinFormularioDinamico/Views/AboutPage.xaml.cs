using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormularioDinamico.Models;

namespace XamarinFormularioDinamico.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            CreateControls();
        }


        public void CreateControls()
        {
            var datos = DataEncuesta.DataInformation();
            foreach (var item in datos.Questions)
            {
                Label label = new Label();
                label.Text = item.Question;

                sl.Children.Add(label);

                StackLayout stackLayoutRespuesta = new StackLayout();
                stackLayoutRespuesta.Orientation = StackOrientation.Horizontal;
                foreach (var question in item.Respuestas)
                {
                    if(question.Tipo.Equals("Entry"))
                    {
                        Entry entry = new Entry();
                        entry.Placeholder = question.Comentario;
                        entry.Text = question.Comentario;
                        stackLayoutRespuesta.Children.Add(entry);

                    }
                    else if (question.Tipo.Equals("Check"))
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.IsChecked = true;
                        stackLayoutRespuesta.Children.Add(checkBox);
                    }
                    
                    
                  

                }
                Button buttonSubirImagen = new Button();
                buttonSubirImagen.Text = "SUBIR IMAGEN";
                //   buttonSubirImagen.Clicked += ButtonSubirImagen_Clicked;
                buttonSubirImagen.Clicked += (s, e) =>
                {
                    MostarMensaje(item);
                };
                stackLayoutRespuesta.Children.Add(buttonSubirImagen);
                sl.Children.Add(stackLayoutRespuesta);
            }


        }
        private void MostarMensaje(EncuestaDetail encuestaDetail)
        {
            Application.Current.MainPage.DisplayAlert("Evento dinamico", $"Mostrar mensaje {encuestaDetail.Question}", "Salir");
        }
        private void ButtonSubirImagen_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("Evento dinamico", "Mostrar mensaje", "Salir");
            
        }
    }
}