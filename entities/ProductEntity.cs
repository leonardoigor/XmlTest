using System.Collections.Generic;
using System.Reflection;

namespace testeXML.entities
{
    public class ProductEntity
    {
        public ProductEntity(int id, string name, string description, decimal price, int quantity, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
            this.Image = image;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }

        public string ProductEntityToXML()
        {
            string xml = "";
            var listProperties = this.GetFieldsFromXML();
            listProperties.ForEach(x =>
            {
                xml += "<" + x + ">" + this.GetValueByPropertyName(x, this) + "</" + x + ">";
            });
            return xml;
        }

        public string GetValueByPropertyName<T>(string propertyName, T Context)
        {

            return Context.GetType().GetProperty(propertyName).GetValue(Context, null).ToString();
        }



        public List<string> GetFieldsFromXML(string xml = "")
        {
            var b = this.GetType().GetProperties();
            var listProperties = new List<string>();
            foreach (var i in b)
            {
                System.Console.WriteLine(i.Name);
                listProperties.Add(i.Name);

                System.Console.WriteLine(this.GetValueByPropertyName(i.Name, this));
            }
            return listProperties;
        }
    }
}