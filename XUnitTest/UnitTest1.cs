using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SwaggerApiNet5.Controllers;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new ProductController();
            var result = controller.Products();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Test2()
        {
            var controller = new ProductController();
            var result = controller.Products();
            var okResult = Assert.IsType<OkObjectResult>(result);
            if (okResult.Value == null) return;
            var json = JsonConvert.SerializeObject(okResult.Value);
            var values = JsonConvert.DeserializeObject<Product>(json);
            if (values == null) return;
            Assert.Equal(1, values.Id);
            Assert.True(values.IsAdmin);
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool IsAdmin { get; set; }
        }
    }
}
