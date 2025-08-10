using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Word Document
        DocumentFactory wordFactory = new WordDocumentFactory();
        IDocument wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();

        // PDF Document
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.Open();

        // Excel Document
        DocumentFactory excelFactory = new ExcelDocumentFactory();
        IDocument excelDoc = excelFactory.CreateDocument();
        excelDoc.Open();
    }
}
