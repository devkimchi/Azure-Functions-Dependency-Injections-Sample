#r "..\Shared\bin\Autofac.dll"
#r "..\Shared\bin\Autofac.Extras.CommonServiceLocator.dll"
#r "..\Shared\bin\AutoMapper.dll"
#r "..\Shared\bin\Functions.EntityModels.dll"
#r "..\Shared\bin\Functions.IoC.dll"
#r "..\Shared\bin\Functions.Mappers.dll"
#r "..\Shared\bin\Functions.Models.dll"
#r "..\Shared\bin\Functions.Services.dll"
#r "..\Shared\bin\Microsoft.Practices.ServiceLocation.dll"

using System;

using Functions.EntityModels;
using Functions.IoC;
using Functions.Mappers;
using Functions.Models;
using Functions.Services;

using Microsoft.Practices.ServiceLocation;

static Functions.IoC.ServiceLocator locator = new Functions.IoC.ServiceLocator();
