	Comprobar si tengo instaladas las "tools" de entity-framework (en terminal)
dotnet ef
	Instalamos usando nuget:
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore (versión acorde a nuestro net core "6")
Microsoft.EntityFrameworkCore.Design (idem versión "6")
Pomelo.EntityFrameworkCore.MySql (idem versión "6")
	Desde consola (powershell) instalar la herramiento global de EF
dotnet tool install --global dotnet-ef
(en clase instalar la versión 6): dotnet tool install --global dotnet-ef --version 6.0.0
	Buscar la cadena de conexión a MySql: 
"server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;"
	Lanzamos "desde la carpeta del proyecto" el comando:
	Importante por el error que nos dió en clase, que previamente "se guade <Save All> todo el proyecto"
dotnet ef dbcontext scaffold "server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools"  Pomelo.EntityFrameworkCore.MySql -o Modelss
	Comprobamos que ha creado una carpeta Models con modelos y DBContext

	Usar la plantilla "controlador.tt" para generar los controladores necesarios (en este caso employees)
    Copiar el fichero generado Controlador.cs al exterior (mediante explorador de archivos) y cambiar espacio de nombres



	--------controlador.tt-----------------------------------------------------------
	<#@ template language="C#" debug="false" #>
<#@ output extension=".cs" #>
<#@ import namespace="System" #>
<#@ import namespace="System.Collections.Generic" #>
<# 
// Parámetros de configuración
string modelName = "Employee"; // Nombre de tu modelo (singular)
string modelPlural = "Employees"; // Nombre plural de la tabla
string DBContextClass = "w3schoolsContext"; // Nombre de la clase de contexto
string namespaceName = "cambiar_namespace";  // Espacio de nombres del proyecto
#>
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using <#= namespaceName #>.Modelss;

namespace <#= namespaceName #>
{
    public class <#= modelName #>Controller
    {
        private <#= DBContextClass #> _context;

        public <#= modelName #>Controller()
        {
            _context = new <#= DBContextClass #>();
        }

        public List<<#= modelName #>> GetAll<#= modelPlural #>()
        {
            return _context.<#= modelPlural #>.ToList();
        }

        public void Add<#= modelName #>(<#= modelName #> <#= modelName.ToLower() #>)
        {
            _context.<#= modelPlural #>.Add(<#= modelName.ToLower() #>);
            _context.SaveChanges();
        }

        public void Update<#= modelName #>(<#= modelName #> <#= modelName.ToLower() #>)
        {
            var existing<#= modelName #> = _context.<#= modelPlural #>.Find(<#= modelName.ToLower() #>.EmployeeId);
            if (existing<#= modelName #> != null)
            {
                // Mapear las propiedades actualizadas aquí
                _context.SaveChanges();
            }
        }

        public void Delete<#= modelName #>(int <#= modelName.ToLower() #>Id)
        {
            var <#= modelName.ToLower() #> = _context.<#= modelPlural #>.Find(<#= modelName.ToLower() #>Id);
            if (<#= modelName.ToLower() #> != null)
            {
                _context.<#= modelPlural #>.Remove(<#= modelName.ToLower() #>);
                _context.SaveChanges();
            }
        }
    }
}

