using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BombaInjetora.Models;


namespace BombaInjetora.Controller
{
    public class RelatorioController
    {
        // Salvar os relatórios no aquivo txt
        public void SalvarConfiguracaoEmArquivo(Relatorio relatorio)
        {
            string caminhoArquivo = @"C:\Users\Aless\OneDrive\Documentos\Programação\Faculdade\Adrian_POO\Projetos\BombaInjetoraTestes.txt";
            relatorio.id = ObterProximoId(caminhoArquivo);

            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
            {
                writer.WriteLine("ID do Relatório: " + relatorio.id);
                writer.WriteLine("Modelo Selecionado: " + relatorio.modeloSelecionado);
                writer.WriteLine("Testes Selecionados: " + string.Join(", ", relatorio.testesSelecionados));
                writer.WriteLine("Provetas Selecionadas: " + string.Join(", ", relatorio.provetasSelecionadas));
                writer.WriteLine("-----------------------------------------------------------");
            }

            MessageBox.Show("Começando testes!");

            // Apenas avisa quando iniciado os testes com os quais serão feitos
            MessageBox.Show($"Iniciando Diagnóstico! \n" +
                $"ID do Relatório: {relatorio.id}\n" +
                $"Modelo Selecionado: {relatorio.modeloSelecionado}\n" +
                $"Testes Selecionados: {string.Join(", ", relatorio.testesSelecionados)}\n" +
                $"Provetas Selecionadas: {string.Join(", ", relatorio.provetasSelecionadas)}\n");
        }
        // Implementação dos IDs em cada relatório
        private int ObterProximoId(string caminhoArquivo)
        {
            // Caso não exista nenhum relatorio no arquivo vai ser o id 1
            if (!File.Exists(caminhoArquivo))
                return 1; 
            string[] diagnosticos = File.ReadAllText(caminhoArquivo).Split(new[] { "-----------------------------------------------------------" }, StringSplitOptions.RemoveEmptyEntries);

            int ultimoId = 0;
            Regex regexId = new Regex(@"ID do Relatório: (\d+)");

            foreach (var diagnostico in diagnosticos)
            {
                var match = regexId.Match(diagnostico.Trim());
                if (match.Success && int.TryParse(match.Groups[1].Value, out int id))
                {
                    ultimoId = Math.Max(ultimoId, id); // Atualiza com o maior ID encontrado
                }
            }

            return ultimoId + 1; // Retorna o próximo ID
        }

        // Adiciona Testes no relatório
        public void AdicionarTeste(string teste, string buttonName, Relatorio relatorio)
        {
            switch (buttonName)
            {
                case "btnEstanqueidade":
                case "btnPreInjecao":
                case "btnMarchaLenta":
                case "btnEmissoes":
                case "btnPlenaCarga":
                    relatorio.testesSelecionados.Add(teste);
                    break;
            }
        }
        // Remove Testes do relatório
        public void RemoverTeste(string teste, string buttonName, Relatorio relatorio)
        {
            switch (buttonName)
            {
                case "btnEstanqueidade":
                case "btnPreInjecao":
                case "btnMarchaLenta":
                case "btnEmissoes":
                case "btnPlenaCarga":
                    relatorio.testesSelecionados.Remove(teste);
                    break;
            }
        }
        // Adiciona as Provetas no relatório
        public void AdicionarProveta(int proveta, string buttonName, Relatorio relatorio)
        {
            switch (buttonName)
            {
                case "btnUm":
                case "btnDois":
                case "btnTres":
                case "btnQuatro":
                    relatorio.provetasSelecionadas.Add(proveta);
                    break;
            }
        }
        // Remove as Provetas do relatório
        public void RemoverProveta(int proveta, string buttonName, Relatorio relatorio)
        {
            switch (buttonName)
            {
                case "btnUm":
                case "btnDois":
                case "btnTres":
                case "btnQuatro":
                    relatorio.provetasSelecionadas.Remove(proveta);
                    break;
            }
        }

    }
}
