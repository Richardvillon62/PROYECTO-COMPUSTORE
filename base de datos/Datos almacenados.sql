--TABLA  USUARIO
create table usuario
( 
id_usuario  int  primary key IDENTITY(1,1),
nombre_completo varchar(50) null,
correo varchar(60) null,
contrasena varchar(50) null
);

--TABLA PROVEEDOR
create table proveedor
( 
id_proveedor  int  primary key IDENTITY(1,1),
nombre_completo varchar(50) null,
ruc int null,
correo varchar(60) null,
contrasena varchar(50) null
);

--TABLA CATALOGO DE PRODUCTOS
create table catalogo_producto
( 
cod_producto  int  primary key IDENTITY(1,1),
nombre_producto varchar(60) null,
descripcion varchar(300) null,
foto image null
);


--CREAR LOS DATOS ALMACENADOS DE INGRESO DE USUARIO
GO
CREATE procedure SP_RegistrarUsuario
--@id int,
@nombre_completo varchar(50),
@correo varchar(70), 
@contrasena varchar (50)

AS
BEGIN
	insert into usuario(nombre_completo, correo, contrasena)
	values(@nombre_completo,  @correo, @contrasena)
END
GO
--BUSCAR DATO USUARIO
CREATE PROCEDURE SP_BuscarCorreoUsuario
    @Correo VARCHAR(70) 
AS
BEGIN
    SELECT id_usuario, nombre_completo, correo, contrasena 
    FROM usuario
    WHERE correo = @Correo;
END;

go
--DATOS ALMACENADOS PARA MODIFICAR DATOS DEL USUARIO
CREATE procedure SP_ModificarUsuario
@id int, @nombre varchar(50),@correo varchar(70),@contrasena varchar(50)
as
update usuario set nombre_completo = @nombre, correo = @correo, contrasena = @contrasena where id_usuario = @id;
GO

--ELIMINAR USUARIO
CREATE PROCEDURE SP_EliminarUsuario
    @id int  
AS
BEGIN
    DELETE FROM usuario WHERE id_usuario = @id; 
END;



--CREAR LOS DATOS ALMACENADOS DE INGRESO DE PROVEEDOR
GO
CREATE procedure SP_RegistrarProveedor
--@id int,
@nombre_completo varchar(80),
@ruc int,
@correo varchar(70), 
@contrasena varchar (50)

AS
BEGIN
	insert into proveedor(nombre_completo, ruc, correo, contrasena)
	values(@nombre_completo, @ruc,  @correo, @contrasena)
END
GO
--BUSCAR DATO PROVEEDOR
CREATE PROCEDURE SP_BuscarDatosCorreoProveedor
    @Correo VARCHAR(70) 
AS
BEGIN
    SELECT id_proveedor, nombre_completo, ruc, correo, contrasena 
    FROM proveedor
    WHERE correo = @Correo;
END;

go
--DATOS ALMACENADOS PARA MODIFICAR DATOS DEL PROVEEDOR
CREATE procedure SPModificarProveedor
@id int, @nombre varchar(50),@correo varchar(70),@contrasena varchar(70)
as
update proveedor set nombre_completo = @nombre, correo = @correo, contrasena = @contrasena where id_proveedor = @id;
GO

--DATOS ALMACENADOS PARA ELIMINAR PROVEEDOR
CREATE PROCEDURE SPEliminarProveedor
    @id int  
AS
BEGIN
    DELETE FROM proveedor WHERE id_proveedor = @id; 
END;

--CREAR LOS DATOS ALMACENADOS DE INGRESO DE CATALOGO DE PRODUCTOS
GO
CREATE procedure SP_RegistrarCatalogoProductos
--@cod int,
@nombre_producto varchar(80),
@descripcion varchar(300), 
@foto image

AS
BEGIN
	insert into catalogo_producto(nombre_producto, descripcion, foto)
	values(@nombre_producto, @descripcion,  @foto)
END
GO

