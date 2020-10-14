using System;
using System.Collections.Generic;
using _06_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContent_RepoTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange– setup the testing objects and prepare the prerequisites for your test.

            StreamingContent content = new StreamingContent();
            StreamingContent_Repo repository = new StreamingContent_Repo();

            //Act– perform the actual work of the test.

            bool addResult = repository.AddContentToDirectory(content);

            //Assert– verify the result.
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContent_Repo repo = new StreamingContent_Repo();

            repo.AddContentToDirectory(content);
            //Act
            List<StreamingContent> contents = repo.GetContents();

            bool directoryHasContent = contents.Contains(content);//checking if contents contains the contents from the directory

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            StreamingContent_Repo repo = new StreamingContent_Repo();
            StreamingContent newContent = new StreamingContent("Toy Story", "toys come to life", 10,
                Genre.Action, MaturityRating.PG);
            repo.AddContentToDirectory(newContent);
            string title = "Toy Story";


            //Act
            StreamingContent searchResult = repo.GetContentByTitle(title);

            //Assert
            Assert.AreEqual(searchResult.Title, title);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent_Repo repo = new StreamingContent_Repo();
            StreamingContent oldContent = new StreamingContent("Toy Story", "toys come to life", 10,
                Genre.Action, MaturityRating.PG);
            StreamingContent newContent = new StreamingContent("Toy Story", "toys come to life", 8,
                Genre.Drama, MaturityRating.PG);
            repo.AddContentToDirectory(newContent);

            //Act
            bool updateResult = repo.UpdateExisitingContent(oldContent.Title, newContent);

            //Assert
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent_Repo repo = new StreamingContent_Repo();
            StreamingContent content = new StreamingContent("Toy Story", "toys come to life", 10,
                Genre.Drama, MaturityRating.PG);

            repo.AddContentToDirectory(content);

            //Act
            StreamingContent oldContent = repo.GetContentByTitle("Toy Story");

            bool removeResult = repo.DeleteExistingContent(oldContent);

            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}
