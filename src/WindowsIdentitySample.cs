using System;
using System.Security.Principal;

namespace Samples{
	public class WindowsIdentitySample{
	public static int Main(string[] args){
	Console.WriteLine("\n| Informaci�n de la identidad ");
	Console.WriteLine("+-----------------------------------------------");
	WindowsIdentity wi = WindowsIdentity.GetCurrent();
	Console.WriteLine("Login: {0}",wi.Name);
	Console.WriteLine("Esta autentificado: {0}",wi.IsAuthenticated);
	Console.WriteLine("Tipo de autentificaci�n: {0}",wi.AuthenticationType);
	Console.WriteLine("Es an�nimo/invitado/sistema: {0}",
			(wi.IsAnonymous ? "An�nimo" : 
			 (wi.IsGuest ? "Invitado" : 
			  (wi.IsSystem ? "Sistema" : "Ninguna"))));
	return 0;
	}
	}
}
