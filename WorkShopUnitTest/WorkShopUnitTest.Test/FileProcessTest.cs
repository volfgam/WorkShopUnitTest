using System;
using Xunit;

namespace WorkShopUnitTest.Test
{
    public class FileProcessTest
    {
        [Fact]
        public void Shoud_Return_True_When_File_Exists()
        {
            #region Arrange

            var spectedReturn = false;
            bool fromCallReturn;
            var filePath = @"C:\Users\marcus.braga.LINX-INVES\Documents\18810974000104-62173-2-2-mide-client.json";

            #endregion Arrange

            #region Act

            fromCallReturn = _fileProcess.FileExists(@filePath);

            #endregion Act

            #region Assert

            Assert.Equal(fromCallReturn, spectedReturn);

            #endregion Assert
        }

        [Fact]
        public void Shoud_Return_False_When_File_Not_Exists()
        {
            #region Arrange

            var spectedReturn = false;
            bool fromCallReturn;
            var filePath = @"C:\Users\marcus.braga.LINX-INVES\Documents\18810974000104-62173-2-2-mide-client-1231.json";

            #endregion Arrange

            #region Act

            fromCallReturn = _fileProcess.FileExists(filePath);

            #endregion Act

            #region Assert

            Assert.Equal(fromCallReturn, spectedReturn);

            #endregion Assert
        }

        [Fact]
        public void Sould_Throw_Exception_When_FileName_Is_Null()
        {
            #region Arrange

            var fromCallReturn = false;
            var filePath = string.Empty;
            var expectedErrorTrue = true;
            var actException = "";

            #endregion Arrange

            #region Act

            try
            {
                _fileProcess.FileExists(filePath);
            }
            catch (Exception ex)
            {
                actException = ex.Message;
                fromCallReturn = true;
            }

            #endregion Act

            #region Assert

            Assert.Equal(fromCallReturn, expectedErrorTrue);
            Assert.Equal(actException, _expectedError);

            #endregion Assert
        }

        public void Sould_Throw_Exception_When_FileName_Is_Null2()
        {
            #region Arrange

            var fromCallReturn = false;
            var filePath = string.Empty;
            var expectedErrorTrue = true;
            var actException = "";

            #endregion Arrange

            #region Act

            try
            {
                _fileProcess.FileExists(filePath);
            }
            catch (Exception ex)
            {
                actException = ex.Message;
                fromCallReturn = true;
            }

            #endregion Act

            #region Assert

            Assert.Throws<ArgumentNullException>("", _fileProcess.FileExists(filePath));
            Assert.Equal(actException, _expectedError);

            #endregion Assert
        }

        private string _expectedError = "Value cannot be null. (Parameter 'Invalid file name.')";

        private readonly FileProcess _fileProcess;

        public FileProcessTest()
        {
            _fileProcess = new FileProcess();
        }
    }
}