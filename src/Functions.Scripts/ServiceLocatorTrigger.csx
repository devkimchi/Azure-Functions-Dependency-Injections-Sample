#load "..\Shared\ServiceLocator.csx"

#r "Newtonsoft.Json"

using System;

using Functions.EntityModels;
using Functions.Services;

using Newtonsoft.Json;

public static void Run(string input, TraceWriter log)
{
    log.Info($"C# manually triggered function called with input: {input}");

    var instance = locator.Instance;

    var service = instance.GetInstance<IUserService>();

    var entities = new List<User>
                   {
                       new User() { UserId = Guid.NewGuid(), FirstName = "Jane", LastName = "Doe" },
                       new User() { UserId = Guid.NewGuid(), FirstName = "Joe", LastName = "Bloggs" }
                   };

    var users = service.GetUsers(entities);

    log.Info(JsonConvert.SerializeObject(users));
}