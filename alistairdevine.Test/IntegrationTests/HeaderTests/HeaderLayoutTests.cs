using alistairdevine.Layouts;

namespace alistairdevine.Test.IntegrationTests.HeaderTests
{
    public class HeaderLayoutTests
    {
        [Fact]
        public void HeaderContainerRendersSuccessfully()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act - Render HeaderLayout Component
            var component = ctx.RenderComponent<HeaderLayout>();

            //Assert - find the parent_name element of the header tag
            Assert.NotNull(component.Find($".header-container"));
        }

        //TODO : Test the error boundary after implementation
        [Fact(Skip = "Still need to implement the error boundary functionality")]
        public void HeaderContainerRendersUnsuccessfully()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act - Render HeaderLayout Component
            var component = ctx.RenderComponent<HeaderLayout>();

            //Assert
            
        }

        [Fact]
        public void LogoContainerRendersSuccessfully()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act - Render HeaderLayout Component
            var component = ctx.RenderComponent<HeaderLayout>();

            //Assert - find the parent_name element of the header tag
            Assert.NotNull(component.Find($".logo-container"));
        }

        [Fact]
        public void LogoImageRendersSuccessfully()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act - Render HeaderLayout Component
            var component = ctx.RenderComponent<HeaderLayout>();

            var logoImageElement = component.Find("img");
            var srcAttributeValue = logoImageElement.GetAttribute("src");

            //Assert
            Assert.NotNull(component.Find($".logo-image"));
            Assert.Equal("images/ali-logo.png", srcAttributeValue);
        }

        [Fact]
        public void NavContainerRendersSuccessfully()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act - Render HeaderLayout Component
            var component = ctx.RenderComponent<HeaderLayout>();

            //Assert
            Assert.NotNull(component.Find($".nav-container"));
        }

        //TODO : break in single prinicial, split button count from button content
        [Fact]
        public void NavButtonsRenderSuccessfully()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act
            var component = ctx.RenderComponent<HeaderLayout>();

            var liElement = component.FindAll("li");
            string[] buttonContent = { "All", "About", "Projects", "Media" };

            //Assert
            Assert.Equal(4, liElement.Count);
            for (int i = 0; i < buttonContent.Length; i++)
            {
                var navLink = liElement[i].FirstChild?.FirstChild;
                Assert.Contains(buttonContent[i], navLink?.TextContent);
            }
        }

        //TODO : Test error message for the navigation container content
        [Fact(Skip = "Still need to implement the error boundary functionality")]
        public void NavButtonsRenderUnsuccessfully()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act - Render HeaderLayout Component
            var component = ctx.RenderComponent<HeaderLayout>();

            //Assert

        }

        [Fact]
        public void ContactContainerRendersSuccessfully()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act - Render HeaderLayout Component
            var component = ctx.RenderComponent<HeaderLayout>();

            //Assert - find the parent_name element of the header tag
            Assert.NotNull(component.Find($".contact-container"));
        }

        [Fact]
        public void ContactContentIsCorrect()
        {
            //Arrange
            using var ctx = new TestContext();

            //Act - Render HeaderLayout Component
            var component = ctx.RenderComponent<HeaderLayout>();

            var contactContent = component.Find($".contact-text").TextContent;

            //Assert
            Assert.NotNull(component.Find($".contact-text"));
            Assert.Equal("Contact", contactContent);
        }
    }
}
