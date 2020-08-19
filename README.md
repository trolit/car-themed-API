<h3>Car themed Fake API</h3>

<p align="justify">Repository stores .NET Core 3.1 Web API training solution in theme "Authorized Car Service"(ordering parts from dealers, servicing history, cars, drivers, mechanics and dealers database etc.) mainly to meet: CQRS design pattern; way to implement pagination; MediatR. Big thanks to <a href="https://github.com/Elfocrash">Nick Chapsas</a> for his great explanations on these things(check his youtube too <a href="https://www.youtube.com/user/ElfocrashDev">here</a>). Only 2 from 6 models are implemented so if someone wants to try for themselves, go ahead. API can also be used to exercise with frontend implementation. Validation from FV relies on ValidationException throwing which I don't like but didn't resolve problem with TResponse wrapped in some result class for ValidationBehaviour. </p>

<h4>Setup</h4>

```
1. Download project as zip file/use git clone <URL> command.
2. Open project.
3. Open PMC(Package Manager Console).
4. Set Data-Layer library as default project for PMC.
5. Write & run update-database.
6. Compile & run project.
7. Hit DataGenerator controller POST action through Swagger.
8. Voilà :)
```

<br/>
<br/>
<br/>

Template generated using <a href="https://github.com/trolit/EzGitDoc">EzGitDoc</a>
