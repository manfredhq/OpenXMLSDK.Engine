using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenXMLSDK.Engine.Word;
using System;
using System.IO;
using OpenXMLSDK.Engine.Word.ReportEngine.Models;

namespace OpenXMLSDK.UnitTest.ReportEngine
{
    [TestClass]
    public class ReportEngineUnitTests
    {
        [TestMethod]
        public void Global_Generation()
        {
            ReportEngineTest.ReportEngine(string.Empty, string.Empty);
        }

        [TestMethod]
        public void WordManagerOpenDocException()
        {
            WordManager manager = new WordManager();
            Exception expectedExcetpion = null;

            try
            {
                manager.OpenDoc("c", true);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            Assert.IsNotNull(expectedExcetpion);
        }

        [TestMethod]
        public void WordManagerOpenDocFromTemplateException()
        {
            WordManager manager = new WordManager();
            Exception expectedExcetpion = null;

            try
            {
                manager.OpenDocFromTemplate("c");
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            Assert.IsNotNull(expectedExcetpion);
        }

        [TestMethod]
        public void WordManagerFindBookmarkException()
        {
            WordManager manager = new WordManager();
            Exception expectedExcetpion = null;

            try
            {
                manager.FindBookmark("c");
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            Assert.IsNotNull(expectedExcetpion);
        }

        [TestMethod]
        public void WordManagerGetBookmarkException()
        {
            WordManager manager = new WordManager();
            Exception expectedExcetpion = null;

            try
            {
                manager.GetBookmarks();
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            Assert.IsNotNull(expectedExcetpion);
        }

        [TestMethod]
        public void WordManagerOpenDocOpenningPdf()
        {
            WordManager manager = new WordManager();
            string file_path = @"c:\temp\test_unit.pdf";
            StreamWriter file = File.CreateText(file_path);
            file.Write("test");
            file.Close();
            Assert.IsFalse(manager.OpenDoc(file_path, true));
        }

        [TestMethod]
        public void WordManagerOpenDocOpenningTxt()
        {
            WordManager manager = new WordManager();
            string file_path = @"c:\temp\test_unit.txt";
            StreamWriter file = File.CreateText(file_path);
            file.Write("test");
            file.Close();
            Assert.IsFalse(manager.OpenDoc(file_path, true));
        }

        [TestMethod]
        public void WordManagerOpenDocOpenningDocx()
        {
            WordManager manager = new WordManager();
            string file_path = @"Resources\test.docx";
            Assert.IsTrue(manager.OpenDoc(file_path, true));
        }

        [TestMethod]
        public void WordManagerOpenDocOpenningZip()
        {
            WordManager manager = new WordManager();
            string file_path = @"c:\temp\test_unit.zip";
            StreamWriter file = File.CreateText(file_path);
            file.Write("test");
            file.Close();
            Assert.IsFalse(manager.OpenDoc(file_path, true));
        }


        [TestMethod]
        public void BaseElementFontColor()
        {
            BaseElement element = new BaseElement("str");
            element.FontColor = "yellow";
            Assert.IsTrue(element.FontColor == "yellow" );
        }

        [TestMethod]
        public void BaseElementFontSize()
        {
            BaseElement element = new BaseElement("str");
            element.FontSize = "8";
            Assert.IsTrue(element.FontSize == "8");
        }

        [TestMethod]
        public void BaseElementItalic()
        {
            BaseElement element = new BaseElement("str");
            element.Italic = true;
            Assert.IsTrue(element.Italic == true);
        }


    }
}

