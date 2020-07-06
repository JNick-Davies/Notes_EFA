using System;
using System.IO;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();//reference the other file, hover on the item and press CTRL + period to set reference
            content.Title = "Toy Story";

            string expected = "Toy Story"; //2 varibles to be used in assert to test. case sensitive 
            string actual = content.Title;

            Assert.AreEqual(expected, actual); //set up test method to test title function. everything before this sets up the stage and this line is the actual test 
        }

        public void SetDescription_ShouldSetCorrectDescription()
        {
            StreamingContent content = new StreamingContent();

            content.Description = "Two Toys Seeking Thier Owner";

            string expected = "Two Toys Seeking Thier Owner";
            string actual = content.Description;

            Assert.AreEqual(expected, actual); 
        }

        [DataTestMethod]
        [DataRow(GenreType.Thriller)]
        [DataRow(GenreType.Romance)]
        [DataRow(GenreType.Comedy)]
        [DataRow(GenreType.Comedy)]

        public void SetGenre_ShouldSetCorrectGenre(GenreType typeOfGenre)
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            //Act
            content.TypeOfGenre = typeOfGenre; //run tests three times with diff data rows 
            //Assert
            Assert.AreEqual(typeOfGenre, content.TypeOfGenre);
        }
    }
}
