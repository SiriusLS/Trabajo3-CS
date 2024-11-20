# CRUD de Alumnos y Asignaturas en C#

Este proyecto es una aplicación de escritorio desarrollada en C# que implementa un CRUD (Create, Read, Update, Delete) para gestionar registros de Alumnos y Asignaturas en una base de datos.

## Características Principales

- **Gestión de Alumnos**: Crear, visualizar, modificar y eliminar registros.
- **Gestión de Asignaturas**: Crear, visualizar, modificar y eliminar registros.
- **Validaciones de Datos**: Verifica campos vacíos y formatos de datos.

## Tecnologías Utilizadas

- **Lenguaje**: C#
- **Framework**: .NET Windows Forms
- **Base de Datos**: SQL Server
- **Interfaz**: Windows Forms con DataGridView

## Requisitos Previos

- Visual Studio
- SQL Server o un motor de base de datos compatible

## Instrucciones de Instalación y Ejecución

1. Clona o descarga el repositorio de este proyecto.
2. Abre el archivo `.sln` en Visual Studio.
3. Configura la cadena de conexión a la base de datos en la capa DAL si es necesario.
4. Ejecuta el proyecto desde Visual Studio.

## Uso de la Aplicación

- **Crear y Modificar**: Completa los campos requeridos en el formulario y haz clic en “Guardar” para agregar o modificar registros.
- **Eliminar**: Selecciona un registro en la tabla y usa el menú contextual para eliminarlo.
- **Validaciones**: La aplicación asegura que los datos sean válidos antes de guardarlos.

## Estructura del Proyecto

- **CRUDBOL**: Capa de negocio con las entidades `AlumnosBOL` y `AsignaturasBOL`.
- **CRUDDAL**: Capa de acceso a datos que gestiona las operaciones CRUD en la base de datos.
- **CRUDBL**: Capa de lógica de negocio que se comunica entre el formulario y la base de datos.
- **CRUD_AA**: Capa de interfaz de usuario con los formularios `Alumnos` y `Asignaturas`.

## Posibles Problemas y Soluciones

- **Error de conexión**: Verifica que la cadena de conexión esté correctamente configurada y que la base de datos esté activa.
