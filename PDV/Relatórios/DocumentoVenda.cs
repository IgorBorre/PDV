using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PDV.Relatórios
{
    internal class DocumentoVenda : IDocument
    {

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(1, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(20));
                page.Header()
                    .Text("Documento Auxiliar de Venda")
                    .Bold().FontSize(32).AlignCenter();                
                page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(column =>
                    {
                        column.Spacing(20);
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

                            table.Cell().Text("1");
                            table.Cell().Text("Produto A");
                            table.Cell().Text("2");
                            table.Cell().Text("$10.00");
                            table.Cell().Text("$20.00");

                            table.Cell().Text("2");
                            table.Cell().Text("Produto B");
                            table.Cell().Text("1");
                            table.Cell().Text("$15.00");
                            table.Cell().Text("$15.00");
                        });

                        //column.Item().PaddingTop(400).Text("Formas de pagamento").Bold().FontSize(16);
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

                            table.Cell().Text("Dinheiro");
                            table.Cell().Text("$20.00");

                            table.Cell().Text("Cartão");
                            table.Cell().Text("$15.00");

                        });
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




 