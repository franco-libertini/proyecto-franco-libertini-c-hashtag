using proyecto_franco_libertini;

//usuario


Usuario usuario1 = new(1, "nombre1", "apellido1", "usuario1", "1234", "mail@gmail.com");
Console.WriteLine("id: {0}, nombre: {1}, apellido: {2}, nombre de usuario: {3}, contraseña: {4}, mail: {5}", usuario1.Id, usuario1.Nombre, usuario1.Apellido, usuario1.NombreUsuario, usuario1.Contrasena, usuario1.Mail);


//producto

Producto prod1 = new(1, "xproducto", 20, 40, 5, 1);
Console.WriteLine("id: {0}, descripcion: {1}, costo: {2}, precio de venta: {3}, stock: {4}, id de usuario: {5}", prod1.Id, prod1.Descripcion, prod1.Costo, prod1.PrecioVenta, prod1.Stock, prod1.IdUsuario);


//productovendido


ProductoVendido prodvendido1 = new(1, 44321, 30, 12312);
Console.WriteLine("id: {0}, idProducto: {1}, stock: {2}, idVenta:{3}", prodvendido1.Id, prodvendido1.IdProducto, prodvendido1.Stock, prodvendido1.IdVenta);


//venta
Venta venta1 = new(1, "sin comentarios", 1);
Console.WriteLine("id: {0}, comentario: {1}, Idusuario: {2}", venta1.Id, venta1.Comentarios, venta1.IdUsuario);


Console.ReadLine();