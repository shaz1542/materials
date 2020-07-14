# Materials

Technical Specifications:

The Application architecture consist of the Domain layer which contains the Entities/Models, Application layer that uses the entities from the domain layer to implement the logic and behaviours and Infrastructure layer that contains the webApi project with the Http Methods to invoke these bahaviours. This seperation of layers will allow us to keep the dependencies among the project minimun, allowing us to extend each layer idependently without effecting other layers

The web api is build on .net core 3.1. I have made use of the following nuget packages

**Automapper** : AutoMapper is a object-to-object mapping library maps objects belonging to dissimilar types.I used it to map Models, Dto and viewModels

**MeadiatR** : I used it to Implement the CQRS pattern to reduce the coupling between Reading and writing so they can later be scaled independently

**RavenDbClient** : this is a .net Nuget package to interact with the RavenDb server by initializing the DocumentStore and injecting the session where required.

Please run the webApi project which runs on the port:52549
It assumes that RavenDB is running and has a database named "materials_db",  this name can be updated in the project startup file if you already have database.

