using CA_CarProject.Abstracts;
using CA_CarProject.AssemblyLine;
using CA_CarProject.ConcreteFactories;

IAbstractFactory bmwFactory = new BMWFactory();
IAbstractFactory volvoFactory= new BMWFactory();
CarAssemblyLine bmwSeriUretim = new CarAssemblyLine(bmwFactory);
CarAssemblyLine volvoSeriUretim = new CarAssemblyLine(volvoFactory);

bmwSeriUretim.AssemblyCar();            
volvoSeriUretim.AssemblyCar();
Console.Read();