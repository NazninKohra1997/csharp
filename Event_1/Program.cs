using Event;

Photoshoot photo = new Photoshoot();

photo.OnClick+= (a)=> Console.WriteLine(a);

photo.Click();