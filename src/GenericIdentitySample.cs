using System;
using System.Security.Principal;

namespace Samples{
	public class GenericIdentitySample{
		public static int Main(string[] args){
			Console.WriteLine("\n| Informaci�n de la identidad");
			Console.WriteLine("+-----------------------------------");
			//lo construimos con los par�metros del nombre y del met�do de autenticaci�n
			GenericIdentity gi = new GenericIdentity("SuperUsuario","Autenticado personalizado");
			Console.WriteLine("Nombre: {0}",gi.Name);
			Console.WriteLine("Tipo de autenticaci�n: {0}",gi.AuthenticationType);
			Console.WriteLine("Esta autenticado: {0}",gi.IsAuthenticated);
			return 0;
		}
	}
}
