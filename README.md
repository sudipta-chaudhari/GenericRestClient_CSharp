# Generic Rest Client in C#

Complete details about source code can be found at : http://sudiptachaudhari.com/generic-rest-client-in-csharp/

Generic REST client in C# for consuming REST services of various types like GET, POST etc supporting basic authentication and passing custom HTTP headers and receive response asynchronously. I have build this sample using .NET Core 2.2 which will work equally well with .NET Framework as no specific libraries targeting .NET Core has been used.

Rest Client is created as a Generic Asynchronous method. I have also used a Constraint with this Generic class that only a class can be used as a placeholder type for the Generic Rest Client class. I have imposed a constraint of class type to the Generic class as the REST api response will the cast to the specific model type that I will define.

Using this REST Client, I will demonstrate the following: –

How to call REST services supporting Http verbs like GET and POST. You can try out services supporting other Http verbs
You will also be able to use basic authentication providing username and password to authenticate the service.
You will also be able to set a HTTP Header value. You can easily customize the REST client to set multiple HTTP Header value.
