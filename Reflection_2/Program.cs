using Reflection;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

DirectoryInfo directory = new DirectoryInfo( Directory.GetCurrentDirectory() );

string config = File.ReadAllText( directory.GetFiles().
                        Where( x=>x.Name.Contains("config") ).First().FullName );

dynamic JsonConfig = JsonConvert.DeserializeObject(config);

Type t = Assembly.GetExecutingAssembly().GetTypes().
                            Where( x=>x.Name==JsonConfig.ClassName.ToString() ).First();

ConstructorInfo constructor = t?.GetConstructor( new Type[] {typeof(string)});
object o = constructor?.Invoke(new object[] {"Jhora"});

MethodInfo method = t?.GetMethod("Id", new Type[] {});

method?.Invoke(o, new object[] {});
