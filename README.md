# Udemy-ASP.NETMVC-EntityFramework-render2web-CrudIndetityProyectoExistente

- Se debe poner a heredar el contexto de IndentityDbContext
- Se hace un update-database para tener la base de datos antes de hacer la migración. En el curso el lo hizo a una base de datos nueva cambiando en la cadena de conexión para que se creara una nueva
- Se hace la migración para implementar Identity add-migration ImplementarIdentityEnProyecto
- update-database para ejecutar la migración y ya se deben crear las tablas de Indentity
- Click derecho en el proyecto agregar elemento con scaffold -> seleccionar Identity -> Seleccionar Reemplazar todos los archivos -> Proveer el DBContext. Con esto se debe crear una carpeta Areas-Identity-Pages
- En el Layout cargar el partial del login
- Asegurarse de tener app.MapRazorPages(); en el program al igual que el AddIdentity y  AddRazorPages();
- Comentar todo lo del emailsender en la página Razor del Register
- 
