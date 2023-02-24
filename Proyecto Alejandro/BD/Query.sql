Create Database Proyecto

Use Proyecto

--Creación Tabla Usuarios
Create Table Usuarios(IdUsuario int primary key identity(0,1), Usuario Nvarchar(20), Contraseña Nvarchar(20), Rol Nvarchar(20))

--Insertar datos a la tabla Usuarios
Insert into Usuarios(Usuario, Contraseña, Rol) values('Alejandro', ENCRYPTBYPASSPHRASE('Admin',  'Admin'), 'Contador General')
Insert into Usuarios(Usuario, Contraseña, Rol) values('Josthim', ENCRYPTBYPASSPHRASE('Admin',  'Admin'), 'Contador Auxiliar')

--Mostrar datos tabla Usuarios
Select * from Usuarios

--Procedimiento almacenado que valide el acceso
Create procedure [Validar Acceso] @Usuario varchar(50), @Contraseña varchar(50)
as
	If exists (Select Usuario from Usuarios where cast (DECRYPTBYPASSPHRASE(@Contraseña, Contraseña) as Varchar(100)) = @Contraseña and Usuario = @Usuario)
		Select 'Acceso Exitoso' as Resultado, Rol from Usuarios
		Where  cast (DECRYPTBYPASSPHRASE(@Contraseña, Contraseña) as Varchar(100)) = @Contraseña and Usuario = @Usuario
		Else
		Select 'Acceso Denegado' as Resultado

--Prueba de la consulta
Execute [Validar Acceso] 'Alejandro', 'Admin'

--Creación Tabla Balance General
Create Table BalanceGeneral(IdBalanceGeneral int primary key identity(0,1), Caja Money, Banco Money, Clientes Money, Mercancías Money, [Total Activos Circulantes] Money,
Terreno Money, Edificio Money, [Mobiliario y Equipo de Oficina] Money, [Total Activos no Circulantes] Money, Salarios Money, [Impuestos a Alcaldía] Money,
[Propaganda y Publicidad] Money, [Gastos de Administración] Money, [Gastos de Ventas] Money, [Total Otros Activos] Money, [Total Activos] Money, [Documentos por Pagar] Money,
[Cuentas por Pagar] Money, [Total Pasivos Circulantes] Money, [Capital Social] Money, [Capital Contribuido] Money, [Total Capital] Money, [Total Pasivos y Capital] Money)

Select * from BalanceGeneral

Drop Table BalanceGeneral

Create Procedure [Añadir Balance General] @Caja Money, @Banco Money, @Clientes Money, @Mercancías Money, @TotalActivosCirculantes Money, @Terreno Money, @Edificio Money, @MobEquip Money,
@TotalActivosNoCirculantes Money, @Salarios Money, @ImpAlcal Money, @PropPublic Money, @GastosAdmin Money, @GastosVentas Money, @TotalOtrosActivos Money, @TotalActivos Money,
@DocPagar Money, @CuentasPagar Money, @TotalPasivosCirculantes Money, @CapitalSocial Money, @CapitalContribuido Money, @TotalCapital Money, @TotalPasivosCapital Money
as
	Insert into BalanceGeneral(Caja, Banco, Clientes, Mercancías, [Total Activos Circulantes], Terreno, Edificio, [Mobiliario y Equipo de Oficina], [Total Activos no Circulantes],
	Salarios, [Impuestos a Alcaldía], [Propaganda y Publicidad], [Gastos de Administración], [Gastos de Ventas], [Total Otros Activos], [Total Activos], [Documentos por Pagar],
	[Cuentas por Pagar], [Total Pasivos Circulantes], [Capital Social], [Capital Contribuido], [Total Capital], [Total Pasivos y Capital]) 
	values(@Caja, @Banco, @Clientes, @Mercancías, @TotalActivosCirculantes, @Terreno, @Edificio, @MobEquip, @TotalActivosNoCirculantes, @Salarios, @ImpAlcal, @PropPublic,
	@GastosAdmin, @GastosVentas, @TotalOtrosActivos, @TotalActivos, @DocPagar, @CuentasPagar, @TotalPasivosCirculantes, @CapitalSocial, @CapitalContribuido, @TotalCapital,
	@TotalPasivosCapital)

Create Table EstadoResultado(IdEstadoResultado int primary key identity(0,1), Ventas Money, [Costos de Venta] Money, [Utilidad Bruta] Money, [Gastos Administrativos] Money,
[Utilidades antes de los Impuestos] Money, [Impuesto de la Renta (IR)] Money, [Utilidad Neta] Money)

Select * from EstadoResultado

Drop Table EstadoResultado

Create Procedure [Añadir Estado Resultado] @Ventas Money, @CostoVentas Money, @UtilidadBruta Money, @GastosAdministrativos Money, @UtilidadAImpuestos Money, @IR Money, @UtilidadNeta Money
as
	Insert into EstadoResultado(Ventas, [Costos de Venta], [Utilidad Bruta], [Gastos Administrativos], [Utilidades antes de los Impuestos], [Impuesto de la Renta (IR)], [Utilidad Neta])
	values (@Ventas, @CostoVentas, @UtilidadBruta, @GastosAdministrativos, @UtilidadAImpuestos, @IR, @UtilidadNeta)