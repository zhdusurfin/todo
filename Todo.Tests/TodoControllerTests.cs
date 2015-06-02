using System.Linq;
using NUnit.Framework;
using Moq;
using Todo.WebAPI.Controllers;
using Todo.WebAPI.Ninject;

namespace Todo.Tests
{
	[TestFixture]
	public class TodoControllerTests
	{
		const string First = "abc", Second = "def";
		private TestController _controller;

		[SetUp]
		public void Setup()
		{
			var mock = new Mock<ITest>();
			mock.Setup(m => m.Tests()).Returns(new[] { First, Second });
			_controller = new TestController(mock.Object);
		}

		[Test]
		public void GetShouldContainsTwoElementsTest()
		{
			Assert.AreEqual(2, _controller.Get().Count());
		}

		[Test]
		public void CheckElementsInAnswerTest()
		{
			var data = _controller.Get().ToArray();
			Assert.AreEqual(First, data[0]);
			Assert.AreEqual(Second, data[1]);
		}
	}
}
