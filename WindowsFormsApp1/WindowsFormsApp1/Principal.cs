using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        System.Windows.Forms.Timer timRun = new System.Windows.Forms.Timer();
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer sSynth = new SpeechSynthesizer();

        GrammarBuilder gBuilder;
        PromptBuilder pBuild = new PromptBuilder();
        Thread agent;

        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();

            Choices commands = new Choices();
            commands.Add(new string[] { "start", "hello", "hi" });
            gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);

            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);


            pBuild.AppendText("Hello, welcome to the order distribution system");
            sSynth.Speak(pBuild);
            pBuild.ClearContent();

            recEngine.SetInputToDefaultAudioDevice();

            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            agent = new Thread(agenteVoz);
            agent.Start();
      
            
        }

        public void agenteVoz()
        {
            DateTime localDate = DateTime.Now;

            pBuild.AppendText("Say start to begin");
            sSynth.Speak(pBuild);
            pBuild.ClearContent();

            recEngine.RecognizeAsync();


            while (true)
            {
                DateTime localDatenew = DateTime.Now;
                if ((localDatenew - localDate).TotalSeconds > 5)
                {
                    break;
                }
            }
            recEngine.RecognizeAsyncStop();
            agenteVoz();
        }

        public void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs er)
        {

            switch (er.Result.Text)
            {
                case "start":

                    picture_rojo.Visible = true;
                    // ponerle delay :c 
                    agent.Abort();
                   

                    Funciones form_funciones = new Funciones(); // se llama el form funciones (hay que cambiarle de nombre)
                    form_funciones.Visible = true;

                    this.Visible = false;


                    break;
                case "hello":
                    pBuild.AppendText("Hello");
                    sSynth.Speak(pBuild);
                    pBuild.ClearContent();
                    break;
                case "hi":
                    pBuild.AppendText("hi");
                    sSynth.Speak(pBuild);
                    pBuild.ClearContent();
                    break;


            }



        }

        private void logica_labels(string accion)
        {
            Console.WriteLine(accion);
            switch (accion)
            {
                case "start":
             
                    picture_rojo.Visible = true;
                    // ponerle delay :c 
                    agent.Abort();
                    Funciones form_funciones = new Funciones(); // se llama el form funciones (hay que cambiarle de nombre)
                    form_funciones.Visible = true;
                    this.Visible = false;
                    break;

            }
       
        }

        private void boton_temporal_Click(object sender, EventArgs e)
        {
           /*string texto = this.textBox_temporal.Text;
           logica_labels(texto);*/
        }
    }
}
