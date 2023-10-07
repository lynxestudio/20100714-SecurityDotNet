using System;
using System.Security.Principal;

namespace Samples{
	public class GenericIdentitySample{
		public static int Main(string[] args){
			Console.WriteLine("\n| Información de la identidad");
			Console.WriteLine("+-----------------------------------");
			//lo construimos con los parámetros del nombre y del metódo de autenticación
			GenericIdentity gi = new GenericIdentity("SuperUsuario","Autenticado personalizado");
			Console.WriteLine("Nombre: {0}",gi.Name);
			Console.WriteLine("Tipo de autenticación: {0}",gi.AuthenticationType);
			Console.WriteLine("Esta autenticado: {0}",gi.IsAuthenticated);
			return 0;
		}
	}
}
