using MagicFilesLib;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";
        private IDirectoryExplorer _directoryExplorer;

        [OneTimeSetUp]
        public void Init()
        {
            var mock = new Mock<IDirectoryExplorer>();
            mock.Setup(de => de.GetFiles(It.IsAny<string>()))
                .Returns(new List<string> { _file1, _file2 });

            _directoryExplorer = mock.Object;
        }

        [Test]
        public void GetFiles_ShouldReturnExpectedFiles()
        {
            var result = _directoryExplorer.GetFiles("dummyPath");

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result, Does.Contain(_file1));
        }
    }
}
