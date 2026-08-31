using PDV.Classes;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PDV.Relatórios
{
    internal class RelatorioSaida : IDocument
    {

        private readonly List<Produtos> _produtos;
        private readonly List<FormasdePagamento>? _formas;
        private readonly string _documento;
        private readonly Clientes? _c;
        public RelatorioSaida(string documento, List<Produtos> produtos, List<FormasdePagamento>? formas, Clientes? c)
        {
            _produtos = produtos;
            _formas = formas;
            _documento = documento;
            _c = c;
        }

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(1, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(20));
                page.Header()
                    .Text("Documento Auxiliar de Saídas")
                    .Bold().FontSize(32).AlignCenter(); 
                page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(column =>
                    {
                        column.Spacing(20);                        

                        column.Item().Row(row =>
                        {
                            row.RelativeItem().Text($"Documento: {_documento}").FontSize(15).Bold();

                            if (_c != null && !string.IsNullOrEmpty(_c.nome))                            
                                row.RelativeItem().AlignRight().Text($"Cliente: {_c.nome}").FontSize(15).Bold();
                            
                        });

                        column.Item().Table(table =>
                        { 
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(50);
                                columns.RelativeColumn(2);
                                columns.ConstantColumn(95);
                                columns.ConstantColumn(80);
                                columns.ConstantColumn(80);
                            });

                            table.Header(header =>
                            {
                                header.Cell().BorderBottom(1).PaddingBottom(3).Text("Item").Bold().FontSize(16);
                                header.Cell().BorderBottom(1).PaddingBottom(3).Text("Descrição").Bold().FontSize(16);
                                header.Cell().BorderBottom(1).PaddingBottom(3).Text("Quantidade").Bold().FontSize(16);
                                header.Cell().BorderBottom(1).PaddingBottom(3).Text("Preço").Bold().FontSize(16);
                                header.Cell().BorderBottom(1).PaddingBottom(3).Text("Total").Bold().FontSize(16);
                            });


                            foreach (Produtos p in _produtos)
                            {
                                table.Cell().Text(p.codigo.ToString());
                                table.Cell().Text(p.descricao);
                                table.Cell().Text(p.quantidade.ToString());
                                table.Cell().Text(p.preco.ToString("F2"));
                                table.Cell().Text((p.preco * p.quantidade).ToString("F2"));
                            }
                        });

                        if (_formas != null && _formas.Count > 0)
                        {
                            column.Item().PaddingTop(400).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(400);
                                    columns.ConstantColumn(100);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().BorderBottom(1).PaddingBottom(3).Text("Forma de Pagamento").Bold().FontSize(16);
                                    header.Cell().BorderBottom(1).PaddingBottom(3).Text("Valor").Bold().FontSize(16);

                                });



                                foreach (FormasdePagamento f in _formas)
                                {
                                    table.Cell().Text(f.descricao);
                                    table.Cell().Text(f.valor.ToString("F2"));
                                }


                            });
                        }
                    });
                page.Footer()
                    .AlignCenter()
                    .Text(x =>
                    {
                        x.Span("Página ");
                        x.CurrentPageNumber();
                    });
                
            });
           
        }
    }
}




 