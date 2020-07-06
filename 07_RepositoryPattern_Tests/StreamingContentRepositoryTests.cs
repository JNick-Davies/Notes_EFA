using System;
using System.Collections.Generic;
using System.Diagnostics;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();//new instance of the repository 

            //act
            bool addResult = repository.AddContentToDirectory(content); //method returns a bool

            //assert
            Assert.IsTrue(addResult);//did it do what we wanted it to do?
        }
        [TestMethod]
        public void GetContents_ShouldRetunCorrectCollection()
        {
            //Arrange 
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(content);

            //act
            List<StreamingContent> contents = repo.GetContents();//lists are not built in testing methods

            bool directoryHasContent = contents.Contains(content);
            //Assert!
            Assert.IsTrue(directoryHasContent);

        }
        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Mr. Right", "Hitman falls in love", MaturityRating.R, 100, GenreType.Action);
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //arrange
            //act
            StreamingContent searchResults = _repo.GetContentByTitle("Mr. Right");
            //assert! did it do the thing?
            Assert.AreEqual(_content, searchResults);
//Dry code (do not repeat yourself)
    //wet code (we enjoy typing!) -- probably how we will start
        }
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //arrange
            StreamingContent newContent = new StreamingContent("Mr. Right", "Hitman falls in love, and gains a new partner in crime", MaturityRating.R, 100, GenreType.Romance);
            //act
            bool updatedResult = _repo.UpdateExistingContent("Mr. Right", newContent);
            //assert
            Assert.IsTrue(updatedResult);
            Assert.AreEqual(GenreType.Romance, _content.TypeOfGenre);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //arrange 
            StreamingContent content = _repo.GetContentByTitle("Mr. Right");
            //act
            bool removeResult = _repo.DeleteExistingContent(content);
            //assert
            Assert.IsTrue(removeResult);

        }
        
    } 
}
