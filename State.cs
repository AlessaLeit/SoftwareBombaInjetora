using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombaInjetora
{ 
        public interface State
        {
            void Handle(Form_ConfigDiagnostico formPrincipal);
            string ProximoEstadoTexto { get; }
        }

        public class IniciarTesteState : State
        {
            public void Handle(Form_ConfigDiagnostico formDiagnostico)
            {
                // Criação do forms
                if (formDiagnostico.formState == null || formDiagnostico.formState.IsDisposed)
                {
                    formDiagnostico.formState = new Form_State();
                    formDiagnostico.formState.StartPosition = FormStartPosition.Manual;
                    formDiagnostico.formState.Location = new Point(formDiagnostico.Location.X + formDiagnostico.Width, formDiagnostico.Location.Y);
                    formDiagnostico.formState.Show();
                }
             }
            public string ProximoEstadoTexto => "Executar";
        }
        
        public class ExecutandoTesteState : State
        {
            public void Handle(Form_ConfigDiagnostico formDiagnostico)
            {
                // Altera o novo Forms enquanto o teste está em executando
                formDiagnostico.formState.UpdateState();
                 MessageBox.Show("Teste em execução.");
            }
         public string ProximoEstadoTexto => "Parar";

        }

        public class DesligarTesteState : State
        {
            public void Handle(Form_ConfigDiagnostico formDiagnostico)
            {
                if (formDiagnostico.formState != null && !formDiagnostico.formState.IsDisposed)
                {
                    formDiagnostico.formState.Close();
                }
            }
            public string ProximoEstadoTexto => "Iniciar";
        }
}





