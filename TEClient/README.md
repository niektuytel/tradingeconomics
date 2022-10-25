# TRADING ECONOMICS Api Client
This is a api client will help calling easly into model based responses.  

## How to use?
```csharp
var client = new ApiClient();

// get  calendar events
var res1 = client.Calendar.GetEvents();
Console.WriteLine(JsonConvert.SerializeObject(res1));
```

Evrything is binded to the `ApiClient`.  

The reason of programming in this way is because it make things simple and flexible as any action has his own POCO class.

# TODO's
- Integrate Post and Put commands
- Check/Ask if all response objects are correctly been filled? (if not, Can I get it in JSON format)
- Create (X)Unit tests
- Reuse simple functions like '*.GetAll()' By using some extra filter (interface) on his Poco