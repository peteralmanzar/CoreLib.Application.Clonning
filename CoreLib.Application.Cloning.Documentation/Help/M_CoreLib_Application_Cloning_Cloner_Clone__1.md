# Cloner.Clone(*T*) Method 
 

Create a copy of an object.

**Namespace:**&nbsp;<a href="N_CoreLib_Application_Cloning">CoreLib.Application.Cloning</a><br />**Assembly:**&nbsp;CoreLib.Application.Cloning (in CoreLib.Application.Cloning.dll) Version: 1.0.0

## Syntax

**C#**<br />
``` C#
public static T Clone<T>(
	T object
)

```

**VB**<br />
``` VB
Public Shared Function Clone(Of T) ( 
	object As T
) As T
```

**C++**<br />
``` C++
public:
generic<typename T>
static T Clone(
	T object
)
```

**F#**<br />
``` F#
static member Clone : 
        object : 'T -> 'T 

```


#### Parameters
&nbsp;<dl><dt>object</dt><dd>Type: *T*<br />The object to be copied.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>\[Missing <typeparam name="T"/> documentation for "M:CoreLib.Application.Cloning.Cloner.Clone``1(``0)"\]</dd></dl>

#### Return Value
Type: *T*<br />The copy of the object.

## Examples
code below shows the example classes (animal and Barn) that are going to be cloned. 
```
[Serializable]
public class Barn
{
  #region Properties
  public int ID { get; set; }
  public string Name { get; set; }
  public List<Animal>
  Animals { get; set; }
  #endregion

  #region Constructors
  public Barn()
  {
    Animals = new List<Animal>();
  }
  #endregion
}
```

```
[Serializable]
internal class Animal
{
  #region Properties
  public int ID { get; set; }
  public string Name { get; set; }
  #endregion

  #region Events
  [field: NonSerialized]
  public event EventHandler MakeNoise;
  #endregion
}
```
 below is an example of cloning a barn object. 
```
//create new barn
var barn = new Barn();

//add animals to the barn
result.Animals.Add(new Animal() { ID = 1, Name = "Cow" });
result.Animals.Add(new Animal() { ID = 2, Name = "Pig" });
result.Animals.Add(new Animal() { ID = 3, Name = "Chicken" });

//clone the barn
var clone = Cloner.Clone(barn);
```


## See Also


#### Reference
<a href="T_CoreLib_Application_Cloning_Cloner">Cloner Class</a><br /><a href="N_CoreLib_Application_Cloning">CoreLib.Application.Cloning Namespace</a><br />