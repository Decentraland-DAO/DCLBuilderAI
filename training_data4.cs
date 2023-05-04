"generate a cube"
const cubeEntity = new Entity()
cubeEntity.addComponent(new BoxShape())
cubeEntity.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
cubeEntity.addComponent(new Material())
cubeEntity.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(cubeEntity)
-- This code creates a cube in Decentraland at position (5, 1, 5) with a random color 


"generate a cube"
// Create a new Entity for the Cube
const cubeEntity = new Entity();

// Add a Transform component to the entity
cubeEntity.addComponent(new Transform());

// Add a GLTFShape component for the 3D model
cubeEntity.addComponent(new GLTFShape('models/cube.glb'));

// Set the position of the cube Entity
cubeEntity.position.set(0, 1, 0);

// Add the cube Entity to the scene
engine.addEntity(cubeEntity);

// Add a click event listener to the cube Entity
cubeEntity.addComponent(
  new OnClick(() => {
    // Rotate the cube Entity
    cubeEntity.getComponent(Transform).rotate(Vector3.Up(), 45);
    // Scale the cube Entity
    cubeEntity.getComponent(Transform).scale.setAll(2);
  })
);

// Generate the cube Entity
engine.addEntity(cubeEntity);

// Add a click event listener to the scene
engine.addComponent(
  new OnClick(() => {
    log('Scene clicked!');
  })
);

// Add the engine to the scene
engine.addComponent(new Engine());

// Add the scene to the hierarchy
engine.addComponent(new Scene());

// Set the initial state of the scene
engine.state = new SceneState();

// Start the engine to run the scene
engine.start();

// Add the scene to the hierarchy
scene.addComponent(new Entity);

// Add the hierarchy to the engine
engine.addHierarchy(scene.hierarchy);

// Add the engine to the scene
scene.addComponent(engine);

// Add the scene to the window
window.addComponent(scene);

// Run the application
Application.run();

</script>

</body>
</html>

import { GLTFShape, Engine, Scene, SceneState } from '@dcl/sdk/ecs'

class Cube extends Entity {
  constructor(transform: Transform) {
    super()
    engine.addEntity(this)
    this.addComponent(transform)
    this.addComponent(new GLTFShape('models/cube.glb'))
    this.addComponent(new SceneState())
  }
}

const scene = new Entity()

const cube = new Cube(new Transform({
  position: new Vector3(0, 1, 0),
  scale: new Vector3(1, 1, 1)
}))

cube.addComponent(new GLTFShape('models/cube.glb'))
cube.addComponent(new SceneState())
scene.addComponent(cube)

scene.addComponent(new OnClick(() => {
  log('Scene clicked!')
}))

engine = new Engine()
engine.addHierarchy(scene.hierarchy)
engine.addHierarchy(scene.hierarchy)
engine.addHierarchy(scene.hierarchy)
engine.addHierarchy(scene.hierarchy)
engine.addHierarchy(scene.hierarchy)
engine.addHierarchy(scene.hierarchy)
engine.addHierarchy(scene.hierarchy)
engine.addHierarchy(scene.hierarchy)
engine.addHierarchy(scene.hierarchy)
engine.addHierarchy(scene


"generate a cube"
// Create the entity 
const cube = new Entity()

// Add shape to the entity 
cube.addComponentOrReplace(new BoxShape())

// Add transform to the entity 
cube.addComponentOrReplace(new Transform({ position: new Vector3(5, 1, 5) }))

// Add material to the entity 
cube.addComponentOrReplace(new Material())

// Add shape to the material 
cube.getComponent(Material).albedoColor = Color3.Blue()

// Add material to the entity 
cube.addComponentOrReplace(new Material())

// Set parent 
cube.setParent(entity)

// Add entity to engine 
engine.addEntity(cube)

// Create a new entity
let cube2 = new Entity()

// Add shape to the entity 
cube2.addComponentOrReplace(new BoxShape())

// Add transform to the entity 
cube2.addComponentOrReplace(new Transform({ position: new Vector3(5, 1, 5) }))

// Add material to the entity 
cube2.addComponentOrReplace(new Material())

// Add shape to the material 
cube2.getComponent(Material).albedoColor = Color3.Blue()

// Add material to the entity 
cube2.addComponentOrReplace(new Material())

// Set parent 
cube2.setParent(entity)

// Add entity to engine 
engine.addEntity(cube2)

// Create a new entity
let cube3 = new Entity()

// Add shape to the entity 
cube3.addComponentOrReplace(new BoxShape())

// Add transform to the entity 
cube3.addComponentOrReplace(new Transform({ position: new Vector3(5, 1, 5) }))

// Add material to the entity 
cube3.addComponentOrReplace(new Material())

// Add shape to the material 
cube3.getComponent(Material).albedoColor = Color3.Blue()

// Add material to the entity 
cube3.addComponentOrReplace(new Material())

// Set parent 
cube3.setParent(entity)

// Add entity to engine 
engine.addEntity(cube3)

// Create a new entity
let cube4 = new Entity()

// Add shape to the entity 
cube4.addComponentOrReplace(new BoxShape())

// Add transform to the entity 
cube4.addComponentOrReplace(new Transform({ position: new Vector3(5, 1, 5) }))

// Add material to the entity 
cube4.addComponentOrReplace(new Material())

// Add shape to the material 
cube4.getComponent(Material).albedoColor = Color3.Blue()

// Add material to the entity 
cube4.addComponentOrReplace(new Material())

// Set parent 
cube4.setParent(entity)

// Add entity to engine 
engine.addEntity(cube4)

// Create a new entity
let cube5 = new Entity()

// Add shape to the entity 
cube5.addComponentOrReplace(new BoxShape())

// Add transform to the entity 
cube5.addComponentOrReplace(new Transform({ position: new Vector3(5, 1, 5) }))

// Add material to the entity 
cube5.addComponentOrReplace(new Material())

// Add shape to the material 
cube5.getComponent(Material).albedoColor = Color3.Blue()

// Add material to the entity 
cube5.addComponentOrReplace(new Material())

// Set parent 
cube5.setParent(entity)

// Add entity to engine 
engine.addEntity(cube5)

// Create a new entity
let cube6 = new Entity()

// Add shape to the entity 
cube6.addComponentOrReplace(new BoxShape())

// Add transform to the entity 
cube6.addComponentOrReplace(new Transform({ position: new Vector3(5, 1, 5) }))

// Add material to the entity 
cube6.addComponentOrReplace(new Material())

// Add shape to the material 
cube6.getComponent(Material).albedoColor = Color


"size(400, 400, P3D);
noStroke();
lights();
translate(232, 192, 0);
sphere(112);"
-- DCLBuilderAI can't help with this as it not related to Decentraland 


"generate a sphere"
-- Creating a sphere in Decentraland 
const sphere = new Entity()
sphere.addComponent(new SphereShape())
sphere.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
sphere.addComponent(new Material())
sphere.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(sphere)


"Create a text shape with the text "Hello World""
const helloWorldText = new TextShape('Hello World')
const helloWorldEntity = new Entity()

helloWorldEntity.addComponent(helloWorldText)
helloWorldEntity.addComponent(new Transform({ position: new Vector3(8, 1, 8) }))

engine.addEntity(helloWorldEntity)
-- This code creates a text shape with the text "Hello World" and adds it to the Decentraland scene 


"sphere(112);"
/** This is editor 4 */
var global_var = 10


"generate a cube"
const cube = new Entity()
cube.addComponent(new BoxShape())
cube.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: new Vector3(1, 1, 1) }))
cube.addComponent(new Material())
cube.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(cube)
-- A cube is generated in Decentraland at position (5, 1, 5) with a random color 


"generate a sphere"
const sphere = new Entity()
sphere.addComponentOrReplace(new Transform({
  position: new Vector3(0, 0, 0),
  scale: new Vector3(1, 1, 1)
}))
sphere.addComponentOrReplace(new SphereShape())
engine.addEntity(sphere)

// Generate a material to color the sphere red
const material = new Material()
material.albedoColor = Color3.Red()
sphere.addComponentOrReplace(material)

// Set the sphere's initial position
sphere.addComponentOrReplace(new Transform({
  position: new Vector3(0, 1, 0)
}))

// Add the sphere to the engine
engine.addEntity(sphere)

// Add a click event listener to the scene to trigger the spawn function
const sceneClick = new Entity()
sceneClick.addComponentOrReplace(new BoxShape())
sceneClick.addComponentOrReplace(new Transform({
  position: new Vector3(0, 1, 0)
}))
engine.addEntity(sceneClick)
sceneClick.addComponentOrReplace(
  new OnClick(() => {
    spawnSpheres()
  })
)

// Spawn spheres when the scene is clicked
function spawnSpheres() {
  const numSpheres = 10
  for (let i = 0; i < numSpheres; i++) {
    const sphere = new Entity()
    sphere.addComponentOrReplace(new Transform({
      position: new Vector3(Math.random() * 10 - 5, 1, Math.random() * 10 - 5),
      scale: new Vector3(Math.random() * 2 + 1, Math.random() * 2 + 1, Math.random() * 2 + 1)
    }))
    sphere.addComponentOrReplace(new SphereShape())
    const material = new Material()
    material.albedoColor = Color3.Green()
    sphere.addComponentOrReplace(material)
    engine.addEntity(sphere)
  }
}

// Define the material
const material = new Material()
material.albedoColor = Color3.Red()

// Create a new material and set its color
const myMaterial = new Material()
myMaterial.albedoColor = Color3.Green()

// Set the material on an entity
const sphere = new Entity()
sphere.addComponentOrReplace(new Transform({
  position: new Vector3(0, 1, 0)
}))
sphere.addComponentOrReplace(new SphereShape())
sphere.addComponentOrReplace(myMaterial)

// Add the sphere to the engine
engine.addEntity(sphere)

// Add a click event listener to the scene to trigger the spawn function
const sceneClick = new Entity()
sceneClick.addComponentOrReplace(new BoxShape())
sceneClick.addComponentOrReplace(new Transform({
  position: new Vector3(0, 1, 0)
}))
engine.addEntity(sceneClick)
sceneClick.addComponentOrReplace(
  new OnClick(() => {
    spawnSpheres()
  })
)

// Spawn spheres when the scene is clicked
function spawnSpheres() {
  const numSpheres = 10
  for (let i = 0; i < numSpheres


"Create a sandwich"
-- DCLBuilderAI can't help with this as it not related to Decentraland 


"Generate a cube"
-- Create a cube in Decentraland 
const cube = new Entity()
cube.addComponent(new BoxShape())
cube.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: new Vector3(1, 1, 1) }))
cube.addComponent(new Material())
cube.getComponent(Material).albedoColor = Color3.White()
engine.addEntity(cube)


"sphere();"
const sphereEntity = new Entity()
sphereEntity.addComponent(new SphereShape())
sphereEntity.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
sphereEntity.addComponent(new Material())
sphereEntity.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(sphereEntity)
-- A sphere has been added to the scene in Decentraland 


"Generate a sandwich object"
-- Creating a sandwich object in Decentraland 

const sandwich = new Entity()
sandwich.addComponent(new GLTFShape('models/sandwich.glb'))
sandwich.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: new Vector3(1, 1, 1) }))
engine.addEntity(sandwich)


"create a sphere"
const sphereEntity = new Entity()
sphereEntity.addComponent(new SphereShape())
sphereEntity.addComponent(new Transform({ position: new Vector3(1, 1, 1), scale: Vector3.One() }))
sphereEntity.addComponent(new Material())
sphereEntity.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(sphereEntity)
-- A sphere has been created in Decentraland 


"Generate a npc"
const npc = new Entity()
npc.addComponent(new GLTFShape('models/npc.glb'))
npc.addComponent(new Transform({ position: new Vector3(5, 0, 5), scale: Vector3.One() }))
engine.addEntity(npc)
-- A simple NPC has been generated in Decentraland 


"generate a sphere"
// Create the sphere entity
const sphere = new Entity()
sphere.addComponentOrReplace(new Transform({
  position: new Vector3(5, 1, 5)
}))
sphere.addComponentOrReplace(new SphereShape())

engine.addEntity(sphere)

// Listen for click to move the sphere
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).translate(Vector3.Forward().scale(10))
  })
)

// Listen for click to rotate the sphere
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).rotate(Vector3.Forward().scale(10))
  })
)

// Listen for click to scale the sphere
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).scale(Vector3.Forward().scale(10))
  })
)

// Listen for click to color the sphere
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).color(Vector3.Forward().color(0)))
  })
)

// Listen for click to toggle sphere material
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Material).albedoColor(Vector3.Forward().materials[0].color)
  })
)

// Listen for click to toggle sphere shape
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Material).metallicness(Vector3.Forward().materials[0].metallicness)
  })
)

// Listen for click to toggle sphere scale
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).scale(Vector3.Forward().scale(10))
  })
)

// Listen for click to toggle sphere rotation
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).rotate(Vector3.Forward().scale(10))
  })
)

// Listen for click to toggle sphere position
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position(Vector3.Forward().position)
  })
)

// Listen for click to end the game
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).translate(Vector3.Forward().scale(0))
  engine.removeEntity(sphere)
  engine.removeComponent(SphericalHazards)
  engine.removeComponent(SphericalCollision)
  engine.removeComponent(SphericalAnchor)
  engine.removeComponent(SphericalEnvironment)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine.removeComponent(SphericalEnvironmentComponent)
  engine


"Generate several sphere objects"
// Create an array to store the sphere entities
const spheres: Entity[] = []

// Generate sphere entities
for (let i = 0; i < 5; i++) {
  const sphere = new Entity()
  sphere.addComponent(new SphereShape())
  sphere.addComponent(new Transform({ position: new Vector3(Math.random() * 10, Math.random() * 2, Math.random() * 10), scale: Vector3.One() }))
  sphere.addComponent(new Material())
  sphere.getComponent(Material).albedoColor = Color3.Random()
  engine.addEntity(sphere)
  spheres.push(sphere)
}

-- This code generates 5 random sphere objects in the Decentraland scene 


"Create a text shape with the text "Hello World""
/** This is editor 4 */
var global_var = 10


"generate a cube"
const cubeEntity = new Entity()
cubeEntity.addComponent(new BoxShape())
cubeEntity.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
engine.addEntity(cubeEntity)
-- A cube is generated at position (5, 1, 5) in Decentraland 


"sphere();"
-- Create a sphere in Decentraland 
const sphereEntity = new Entity()
sphereEntity.addComponent(new SphereShape())
sphereEntity.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
sphereEntity.addComponent(new Material())
sphereEntity.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(sphereEntity)


"Create a green sphere"
const greenSphere = new Entity()
greenSphere.addComponent(new SphereShape())
greenSphere.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
const greenMaterial = new Material()
greenMaterial.albedoColor = Color3.Green()
greenSphere.addComponent(greenMaterial)
engine.addEntity(greenSphere)
-- A green sphere has been created in Decentraland 


"create an avocado"
const avocadoEntity = new Entity()
avocadoEntity.addComponent(new GLTFShape('models/avocado.glb'))
avocadoEntity.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: new Vector3(0.5, 0.5, 0.5) }))
engine.addEntity(avocadoEntity)


"Generate 8 sphere objects placed vertically"
const scene = new Entity()
engine.addEntity(scene)

const sphereContainer = new Entity()
sphereContainer.addComponent(new Transform({ position: new Vector3(8, 0, 8) }))
engine.addEntity(sphereContainer)

const sphereMaterial = new Material()
sphereMaterial.albedoColor = Color3.Random()

for (let i = 0; i < 8; i++) {
  const sphere = new Entity()
  sphere.addComponent(new SphereShape())
  sphere.addComponent(new Transform({ position: new Vector3(0, i * 2, 0), scale: Vector3.One() }))
  sphere.addComponent(sphereMaterial)
  sphere.setParent(sphereContainer)
  engine.addEntity(sphere)
}
-- This code generates 8 sphere objects placed vertically in Decentraland 


"Create a green sphere"
/** This is editor 4 */
var global_var = 10


"generate a game that allows you to earn points by picking up avocados"
import { engine, Entity, Transform, BoxShape, Color3, Vector3, Material, AlbedoMaterial, MetallicMaterial } from 'decentraland-ecs'

// Create a game that awards points for picking up avocados
const avocadoGame = new Entity()
avocadoGame.addComponent(new Transform({ position: new Vector3(5, 0, 5) }))
avocadoGame.addComponent(new BoxShape())

// Create a material that determines how shiny the avocado is
const avocadoMaterial = new Material()
avocadoMaterial.albedoColor = Color3.FromHexString('#FFA0724')

// Add the material to the avocado entity
avocadoEntity.addComponent(avocadoMaterial)

// Add the avocado game to the scene
engine.addEntity(avocadoEntity)

// Add points to the game when an avocado is picked up
const avocadoPickup = new Entity()
avocadoPickup.addComponent(new Transform({ position: new Vector3(5, 1, 5) }))
avocadoPickup.addComponent(new BoxShape())

// Create a material that determines how shiny the avocado is
const avocadoMaterial = new Material()
avocadoMaterial.albedoColor = Color3.FromHexString('#FFA0724')

// Add the material to the avocado entity
avocadoEntity.addComponent(avocadoMaterial)

// Add the avocado game to the scene
engine.addEntity(avocadoEntity)

// Add points to the game when an avocado is eaten
const avocadoEat = new Entity()
avocadoEat.addComponent(new Transform({ position: new Vector3(5, 2, 5) }))
avocadoEat.addComponent(new BoxShape())

// Create a material that determines how shiny the avocado is
const avocadoMaterial = new Material()
avocadoMaterial.albedoColor = Color3.FromHexString('#FFA0724')

// Add the material to the avocado entity
avocadoEntity.addComponent(avocadoMaterial)

// Add the avocado game to the scene
engine.addEntity(avocadoEntity)

// Add points to the game when an avocado is eaten
const avocadoEat2 = new Entity()
avocadoEat2.addComponent(new Transform({ position: new Vector3(5, 3, 5) }))
avocadoEat2.addComponent(new BoxShape())

// Create a material that determines how shiny the avocado is
const avocadoMaterial = new Material()
avocadoMaterial.albedoColor = Color3.FromHexString('#FFA0724')

// Add the material to the avocado entity
avocadoEntity.addComponent(avocadoMaterial)

// Add the avocado game to the scene
engine.addEntity(avocadoEntity)

// Add points to the game when an avocado is eaten
const avocadoEat3 = new Entity()
avocadoEat3.addComponent(new Transform({ position: new Vector3(5, 4, 5) }))
avocadoEat3.addComponent(new BoxShape())

// Create a material that determines how shiny the avocado is
const avocadoMaterial = new Material()
avocadoMaterial.albedoColor = Color3.FromHexString('#FFA0724')

// Add the material to the avocado entity
avocadoEntity.addComponent(avocadoMaterial)

// Add the avocado game to the scene
engine.addEntity(avocadoEntity)

// Add points to the game when an avocado is eaten
const avocadoEat4 = new Entity()
avocadoEat4.addComponent(new Transform({ position: new Vector3(5, 5, 5) }))
avocadoEat4.addComponent(new BoxShape())

// Create a material that determines how shiny the avocado is
const avocadoMaterial = new Material()
avocadoMaterial.albedoColor = Color3.FromHexString('#FFA0724')

// Add the material to the avocado entity
avocadoEntity.addComponent(avocadoMaterial)

// Add the avocado game to the scene
engine.addEntity(avocadoEntity)

// Add points to the game when an avocado is eaten
const avocadoEat5 = new Entity()
avocadoEat5.addComponent(new Transform({ position: new Vector3(5, 6, 5) }))
avocadoEat5.addComponent(new BoxShape())

// Create a material that determines how shiny the avocado is
const avocadoMaterial


"create an invisible sphere"
-- DCLBuilderAI code for creating an invisible sphere in Decentraland 

const invisibleSphere = new Entity()
invisibleSphere.addComponent(new SphereShape())
invisibleSphere.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))

const invisibleMaterial = new Material()
invisibleMaterial.albedoColor = Color4.FromHexString('#00000000')
invisibleMaterial.transparencyMode = 2

invisibleSphere.addComponent(invisibleMaterial)
engine.addEntity(invisibleSphere)


"Create a pen with a cilinder and a cone. Add color."
-- Creating a pen with a cylinder and a cone, and adding color in Decentraland 

// Create a new entity for the cylinder
const cylinderEntity = new Entity()
cylinderEntity.addComponent(new CylinderShape())
cylinderEntity.addComponent(new Transform({ position: new Vector3(1, 0.5, 1), scale: new Vector3(1, 1, 1) }))
const cylinderMaterial = new Material()
cylinderMaterial.albedoColor = Color3.FromHexString("#FF0000") // Red color
cylinderEntity.addComponent(cylinderMaterial)
engine.addEntity(cylinderEntity)

// Create a new entity for the cone
const coneEntity = new Entity()
coneEntity.addComponent(new ConeShape())
coneEntity.addComponent(new Transform({ position: new Vector3(1, 2, 1), scale: new Vector3(1, 1, 1) }))
const coneMaterial = new Material()
coneMaterial.albedoColor = Color3.FromHexString("#00FF00") // Green color
coneEntity.addComponent(coneMaterial)
engine.addEntity(coneEntity)


"Generate a class that has a function that creates a new sphere object at a random location"
-- DCLBuilderAI generated code for creating a class with a function to create a new sphere object at a random location in Decentraland 

class SphereSpawner {
  spawnRandomSphere() {
    const randomPosition = new Vector3(
      Math.random() * 16 + 1,
      Math.random() * 16 + 1,
      Math.random() * 16 + 1
    )

    const newSphere = new Entity()
    newSphere.addComponent(new SphereShape())
    newSphere.addComponent(new Transform({ position: randomPosition, scale: Vector3.One() }))
    newSphere.addComponent(new Material())
    newSphere.getComponent(Material).albedoColor = Color3.Random()
    engine.addEntity(newSphere)
  }
}

-- Usage example:
const sphereSpawner = new SphereSpawner()
sphereSpawner.spawnRandomSphere()



"Create a pen with a cilinder and a cone. Add color."
/** This is editor 4 */
var global_var = 10


"Generate a npc"
/** This is editor 4 */
var global_var = 10


"generate a cube"
// Create the entity 
const cube = new Entity()

// Transform the entity to give it a position
cube.addComponentOrReplace(new Transform({
  position: new Vector3(2, 1, 2)
}))

// Add shape to the entity 
cube.addComponentOrReplace(new BoxShape())

// Render entity in scene
engine.addEntity(cube)

// Add click event to the entity
cube.addComponent(
  new OnClick(() => {
    log('Cube clicked!')
    engine.removeEntity(cube)
  })
)

// Example function to render entity in scene
function renderEntity(entity: Entity) {
  // Get entity in scene
  const entity = entity ? entity : engine.getEntity(Transform)

  // Get entity shape
  const entityShape = entity.getComponent(Transform).position.clone()

  // Create cube entity
  const cubeEntity = new Entity()
 
  // Transform entity to give it a position
  cubeEntity.addComponentOrReplace(new Transform({
    position: entityShape
  }))
 
  // Add shape to the entity
  cubeEntity.addComponentOrReplace(new BoxShape())
 
  // Render entity in scene
  engine.addEntity(cubeEntity)
}

// Example function to get entity in scene
function getEntity(entity: Entity): Entity {
  // Get entity in scene
  const entity = entity ? entity : engine.getEntity(entity)

  // Get entity shape
  const entityShape = entity.getComponent(entity).position.clone()

  // Return entity shape
  return entityShape
}

// Example function to remove entity in scene
function removeEntity(entity: Entity): void {
  // Remove entity in scene
  engine.removeEntity(entity)
}

// Example function to get all entities in scene
function getAllEntities(scene: IScene): Entity[] {
  // Get all entities in scene
  return engine.getEntities(scene)
}

// Example function to get entity in scene
function getEntity(entity: Entity): Entity {
  // Get entity in scene
  const entity = getEntity(entity)

  // Get entity shape
  const entityShape = entity.getComponent(entity).position.clone()

  // Return entity shape
  return entityShape
}

// Example function to get all entities in scene
function getAllEntitiesInScene(entity: Entity): void {
  // Get all entities in scene
  engine.getEntitiesInScene(entity)
}

// Example function to get entity in scene
function getEntityInScene(entity: Entity): void {
  // Get entity in scene
  const entity = getEntity(entity)

  // Get entity shape
  const entityShape = entity.getComponent(entity).position.clone()

  // Return entity shape
  return entityShape
}

// Example function to get all entities in scene
function getAllEntitiesInScene(entity: Entity): void {
  // Get all entities in scene
  engine.getEntitiesInScene(entity)
}

// Example function to get entity in scene
function getEntityInScene(entity: Entity): void {
  // Get entity in scene
  const entity = getEntity(entity)

  // Get entity shape
  const entityShape = entity.getComponent(entity).position.clone()

  // Return entity shape
  return entityShape
}

// Example function to get all entities in scene
function getAllEntitiesInScene(entity: Entity): void {
  // Get all entities in scene
  engine.getEntitiesInScene(entity)
}

// Example function to get entity in scene
function getEntityInScene(entity: Entity): void {
  // Get entity in scene
  const entity = getEntity(entity)

  // Get entity shape
  const entityShape = entity.getComponent(entity).position.clone()

  // Return entity shape
  return entityShape
}

// Example function to get all entities in scene
function getAllEntitiesInScene(entity: Entity): void {
  // Get all entities in scene
  engine.getEntitiesInScene(entity)
}

// Example function to get entity in scene
function getEntityInScene(entity: Entity): void {
  // Get entity in scene
  const entity =


"create small cube"
const smallCube = new Entity()
smallCube.addComponent(new BoxShape())
smallCube.addComponent(new Transform({
  position: new Vector3(5, 1, 5),
  scale: new Vector3(0.5, 0.5, 0.5)
}))
smallCube.addComponent(new Material())
engine.addEntity(smallCube)
-- A small cube has been created in Decentraland at position (5, 1, 5) with a scale of 0.5 


"generate a cube"
// Creating a new Entity for the Cube
const cubeEntity = new Entity();

// Adding a Transform component to the entity
cubeEntity.addComponent(new Transform());

// Adding a GLTFShape component for the 3D model
cubeEntity.addComponent(new GLTFShape('models/cube.glb'));

// Adding a Material component for the color of the cube
cubeEntity.addComponent(new Material());
cubeEntity.getComponent(Material).albedoColor = Color3.Blue();

// Adding the cube Entity to the scene
engine.addEntity(cubeEntity);

// Adding a click event to the cube Entity
cubeEntity.addComponent(
  new OnClick(() => {
    cubeEntity.getComponent(Transform).scale.z *= 0.1;
  })
);

// Playing the animation of the cube when it is created
cubeEntity.addComponent(
  new utils.Delay(2000),
  new utils.Trigger()
);

// Adding a script to change the color of the cube when it is clicked
export class ColorCube implements ISubject {
  public isPointerDown = false;

  public color = Color3.Red();

  public onPointerDown(evt: PointerEvent) {
    this.isPointerDown = true;
    this.color = Color3.Green();
  }

  public onPointerUp(evt: PointerEvent) {
    this.isPointerDown = false;
    this.color = Color3.Red();
  }
}

// Adding a script to change the color of the cube when it is clicked
engine.addSystem(new utils.System({
  update(dt: number) {
    const entities = engine.getEntitiesWith(utils.HasComponent(utils.Trigger)) as Entity[];
    for (const entity of entities) {
      if (entity.getComponent(ColorCube).isPointerDown) {
        entity.getComponent(Material).albedoColor = Color3.Green();
      }
    }
  },
  () => {
    const entities = engine.getEntitiesWith(utils.HasComponent(utils.Trigger)) as Entity[];
    for (const entity of entities) {
      if (entity.getComponent(ColorCube).isPointerDown) {
        entity.getComponent(Material).albedoColor = Color3.Red();
      }
    }
  }
})
);

// Adding a script to change the color of the cube when it is clicked
export class ColorCube implements ISubject {
  public isPointerDown = false;

  public color = Color3.Red();

  public onPointerDown(evt: PointerEvent) {
    this.isPointerDown = true;
    this.color = Color3.Green();
  }

  public onPointerUp(evt: PointerEvent) {
    this.isPointerDown = false;
    this.color = Color3.Red();
  }
}

// Adding a script to change the color of the cube when it is clicked
export class ColorCube implements ISubject {
  public isPointerDown = false;

  public color = Color3.Red();




"Create a text shape with the text "Hello World""
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.addEntity(textShape)

// Output: Hello World

// Create a text shape with the text "Hello World"
const textShape = new Entity()
textShape.addComponent(new TextShape("Hello World"))
textShape.getComponent(TextShape).value = "Hello World"

engine.


"create a player class that can be used to switch avatars"
export class Player extends Entity {
  constructor(model: GLTFShape, transform: Transform) {
    super()
    engine.addEntity(this)
    this.addComponent(model)
    this.addComponent(transform)
  }
}

// Create a player entity
const player = new Player(
  new GLTFShape('models/player.glb'),
  new Transform({
    position: new Vector3(8, 0, 8)
  })
)

// Add a player to the engine
engine.addEntity(player)

// Switch player avatar
class PlayerAvatarSystem {
  update(dt: number) {
    player.getComponent(Transform).position.x = Math.random() * 0.5 + 0.5
  }
}

// Create a player avatar system
const playerAvatarSystem = new PlayerAvatarSystem()

// Add a player avatar system to the engine
engine.addSystem(playerAvatarSystem)





// Switch player avatar
class SwitchPlayerAvatarSystem {
  update(dt: number) {
    playerAvatarSystem.update(dt)
    if (Input.isKeyDown('W')) {
      playerAvatarSystem.update('world')
    }
  }
}

// Create a switch player avatar system
const switchPlayerAvatarSystem = new SwitchPlayerAvatarSystem()

// Add a switch player avatar system to the engine
engine.addSystem(switchPlayerAvatarSystem)





// Update the world when the player switches avatars
class SwitchWorldSystem {
  update(dt: number) {
    const player = playerAvatarSystem.getComponent(Transform).position.x === 0 ? playerAvatarSystem.update('world') : -1
    if (player) {
      player.getComponent(Transform).position.x = player.getComponent(Transform).position.x === 0 ? Math.random() * 0.5 + 0.5 : 0
      playerAvatarSystem.update('world')
    }
  }
}

// Create a switch world system
const switchWorldSystem = new SwitchWorldSystem()

// Add a switch world system to the engine
engine.addSystem(switchWorldSystem)





// Switch player avatar
class SwitchPlayerSystem {
  update(dt: number) {
    const player = playerAvatarSystem.getComponent(Transform).position.x === 0 ? playerAvatarSystem.update('player') : -1
    if (player) {
      player.getComponent(Transform).position.x = player.getComponent(Transform).position.x === 0 ? Math.random() * 0.5 + 0.5 : 0
      playerAvatarSystem.update('player')
    }
  }
}

// Create a switch player system
const switchPlayerSystem = new SwitchPlayerSystem()

// Add a switch player system to the engine
engine.addSystem(switchPlayerSystem)





// Switch player avatar
class SwitchPlayerAvatarSystem {
  update(dt: number) {
    const player = playerAvatarSystem.getComponent(Transform).position.x === 0 ? playerAvatarSystem.update('player') : -1
    if (player) {
      player.getComponent(Transform).position.x = player.getComponent(Transform).position.x === 0 ? Math.random() * 0.5 + 0.5 : 0
      playerAvatarSystem.update('player')
    }
  }
}

// Create a switch player avatar system
const switchPlayerAvatarSystem = new SwitchPlayerAvatarSystem()

// Add a switch player avatar system to the engine
engine.addSystem(switchPlayerAvatarSystem)





// Switch player avatar
class SwitchPlayerAvatarSystem {
  update(dt: number) {
    const player = playerAvatarSystem.getComponent(Transform).position.x === 0 ? playerAvatarSystem.update('player') : -1
    if (player) {
      player.getComponent(Transform).position.x = player.getComponent(Transform).position.x


"create a player class that can be used to switch avatars"
class Player {
  constructor(avatarURL) {
    this.avatarURL = avatarURL
    this.avatarEntity = new Entity()
    this.avatarEntity.addComponent(new GLTFShape(this.avatarURL))
    this.avatarEntity.addComponent(new Transform({ position: new Vector3(1, 0, 1), scale: new Vector3(1, 1, 1) }))
    engine.addEntity(this.avatarEntity)
  }

  switchAvatar(newAvatarURL) {
    this.avatarURL = newAvatarURL
    this.avatarEntity.removeComponent(GLTFShape)
    this.avatarEntity.addComponent(new GLTFShape(this.avatarURL))
  }
}

-- Usage example:
const player = new Player('models/avatar1.gltf')
player.switchAvatar('models/avatar2.gltf')



"create a player class that can be used to switch avatars"
class PlayerAvatar {
  constructor(entity, avatarURL) {
    this.entity = entity
    this.avatarURL = avatarURL
  }

  switchAvatar(newAvatarURL) {
    this.avatarURL = newAvatarURL
    this.entity.getComponent(AvatarShape).src = this.avatarURL
  }
}

-- Example usage 
const playerEntity = new Entity()
playerEntity.addComponent(new AvatarShape('avatars/avatar1.glb'))
playerEntity.addComponent(new Transform({ position: new Vector3(1, 0, 1) }))
engine.addEntity(playerEntity)

const player = new PlayerAvatar(playerEntity, 'avatars/avatar1.glb')
player.switchAvatar('avatars/avatar2.glb') // Switch to a different avatar


"Generate a class (extends the inherent entity class) has a function that creates a new sphere object at a random location (the sphere object is parented to the class)"
-- DCLBuilderAI: Creating a class that extends the Entity class and has a function to create a new sphere object at a random location in Decentraland 

class RandomSphere extends Entity {
  constructor() {
    super()
    this.createSphere()
  }

  createSphere() {
    const sphere = new Entity()
    sphere.addComponent(new SphereShape())
    sphere.addComponent(new Transform({ position: this.randomPosition(), scale: Vector3.One() }))
    sphere.addComponent(new Material())
    sphere.getComponent(Material).albedoColor = Color3.Random()
    engine.addEntity(sphere)
    sphere.setParent(this)
  }

  randomPosition() {
    const x = Math.random() * 10
    const y = Math.random() * 10
    const z = Math.random() * 10
    return new Vector3(x, y, z)
  }
}

-- Usage: 
const myRandomSphere = new RandomSphere()


"create a player class that can be used to switch avatars"
class Player {
  constructor(entity, avatarURL) {
    this.entity = entity
    this.avatarURL = avatarURL
  }

  switchAvatar(newAvatarURL) {
    this.avatarURL = newAvatarURL
    const avatarComponent = new AvatarShape()
    avatarComponent.skinURL = this.avatarURL
    this.entity.addComponentOrReplace(avatarComponent)
  }
}

const playerEntity = new Entity()
playerEntity.addComponent(new Transform({ position: new Vector3(0, 0, 0) }))
engine.addEntity(playerEntity)

const player = new Player(playerEntity, 'avatars/avatar1.glb')

function changeAvatar() {
  player.switchAvatar('avatars/newAvatar.glb')
}

-- Call changeAvatar() function to switch the player's avatar 


"create a player class that can be used to switch avatars"
export class Player extends Entity {
  constructor(model: GLTFShape, position: Vector3) {
    super()
    engine.addEntity(this)
    this.addComponent(model)
    this.addComponent(new Transform({ position: position }))
    this.addComponent(new Animator())
    this.getComponent(Animator).addClip(new AnimationState("Walk", { looping: false }))
    this.setParent(scene)
  }

  playAnimation() {
    this.getComponent(Animator).getClip("Walk").stop()
    this.getComponent(Animator).getClip("Walk").play()
  }
}

const player = new Player(new GLTFShape("models/Player.glb"), new Vector3(0, 0, 0))
engine.addEntity(player)
player.addComponent(new utils.TriggerComponent("Trigger", {
  onCameraEnter: () => {
    player.playAnimation()
  }
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(0, 1, 0), {
  duration: 1,
  easing: utils.Easing.QuadInOut,
  loop: true
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(0, 0.5, 0), {
  duration: 1,
  easing: utils.Easing.QuadInOut,
  loop: true
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(0.5, 0, 0), {
  duration: 1,
  easing: utils.Easing.QuadInOut,
  loop: true
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(1, 0, 0), {
  duration: 1,
  easing: utils.Easing.QuadInOut,
  loop: true
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(0, 0.5, 0), {
  duration: 1,
  easing: utils.Easing.QuadInOut,
  loop: true
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(0.5, 0, 0), {
  duration: 1,
  easing: utils.Easing.QuadInOut,
  loop: true
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(1, 0, 0), {
  duration: 1,
  easing: utils.Easing.QuadInOut,
  loop: true
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(0, 0.5, 0), {
  duration: 1,
  easing: utils.Easing.QuadInOut,
  loop: true
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(0.5, 0, 0), {
  duration: 1,
  easing: utils.Easing.QuadInOut,
  loop: true
}))

player.addComponent(new utils.MoveTransformComponent(new Vector3(1, 0, 0), {
  duration: 1,
  easing: utils.Easing


"create a player class that can be used to switch avatars"
class Player {
  constructor(avatarURL) {
    this.avatarURL = avatarURL
  }

  switchAvatar(newAvatarURL) {
    this.avatarURL = newAvatarURL
    const userData = {
      displayName: 'Player',
      avatar: {
        bodyShape: 'dcl://base-avatars/BaseFemale',
        wearables: [newAvatarURL],
      },
    }
    const action = {
      type: 'UpdateUserData',
      payload: userData,
    }
    sendExternalAction(action)
  }
}

const player = new Player('dcl://base-avatars/BaseFemale')
-- To switch avatars, call player.switchAvatar('newAvatarURL') with the desired avatar URL 


"create a player class that can be used to switch avatars"
class Player {
  constructor(entity) {
    this.entity = entity
    this.avatar = new AvatarShape()
    this.entity.addComponent(this.avatar)
  }

  switchAvatar(avatarURL) {
    this.avatar.src = avatarURL
  }
}

const playerEntity = new Entity()
engine.addEntity(playerEntity)

const player = new Player(playerEntity)
player.switchAvatar('https://example.com/newAvatar.glb')
-- Call player.switchAvatar() with a new avatar URL to switch avatars 


"create a player class that can be used to switch avatars"
class Player {
  constructor(avatarURL) {
    this.avatarURL = avatarURL
  }

  switchAvatar(newAvatarURL) {
    this.avatarURL = newAvatarURL
    -- Update the player's avatar in Decentraland 
    executeTask(async () => {
      await updateUserAvatar({ avatarURL: this.avatarURL })
    })
  }
}

-- Usage example 
const player = new Player('https://avatars.example.com/avatar1.glb')
player.switchAvatar('https://avatars.example.com/avatar2.glb')


"Add a green cube"
const cube = new Entity()
cube.addComponent(new BoxShape())
cube.addComponent(new Transform({
  position: new Vector3(5, 0, 5),
  scale: new Vector3(1, 1, 1)
}))
cube.addComponent(new Material())
cube.getComponent(Material).albedoColor = new Color3(0, 1, 0)
engine.addEntity(cube)

cube.addComponent(
  new OnPointerDown(() => {
    cube.getComponent(Material).albedoColor = new Color3(1, 0, 0)
  })
)

engine.addSystem(
  new class {
    update(dt: number) {
      cube.getComponent(Material).albedoColor = new Color3(0, 1, 0)
    }
  }
)

cube.addComponent(
  new OnPointerDown(() => {
    cube.getComponent(Material).albedoColor = new Color3(1, 0, 0)
  })
)

engine.addSystem(
  new class {
    update(dt: number) {
      cube.getComponent(Material).albedoColor = new Color3(0, 1, 0)
    }
  }
)

cube.addComponent(
  new OnPointerDown(() => {
    cube.getComponent(Material).albedoColor = new Color3(1, 0, 0)
  })
)

cube.addComponent(
  new OnPointerDown(() => {
    cube.getComponent(Material).albedoColor = new Color3(1, 0, 0)
  })
)

engine.addSystem(
  new class {
    update(dt: number) {
      cube.getComponent(Material).albedoColor = new Color3(0, 1, 0)
    }
  }
)

cube.addComponent(
  new OnPointerDown(() => {
    cube.getComponent(Material).albedoColor = new Color3(1, 0, 0)
  })
)

cube.addComponent(
  new OnPointerDown(() => {
    cube.getComponent(Material).albedoColor = new Color3(1, 0, 0)
  })
)

engine.addSystem(
  new class {
    update(dt: number) {
      cube.getComponent(Material).albedoColor = new Color3(0, 1, 0)
    }
  }
)

cube.addComponent(
  new OnPointerDown(() => {
    cube.getComponent(Material).albedoColor = new Color3(1, 0, 0)
  })
)

cube.addComponent(
  new OnPointerDown(() => {
    cube.getComponent(Material).albedoColor = new Color3(1, 0, 0)
  })
)

engine.addSystem(
  new class {
    update(dt: number) {
      cube.getComponent(Material).albedoColor = new Color3(0, 1, 0)
    }
  }
)

cube.addComponent(


"create a sphere"
const sphere = new Entity()
sphere.addComponent(new SphereShape())
sphere.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
sphere.addComponent(new Material())
sphere.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(sphere)
-- A sphere has been created in Decentraland at position (5, 1, 5) with a random color 


"Add a green cube"
/** This is editor 4 */
var global_var = 10


"Create pelican"
-- DCLBuilderAI code for creating a pelican in Decentraland 

// Create a new entity for the pelican
const pelican = new Entity()

// Add a GLTFShape component to load the pelican model
pelican.addComponent(new GLTFShape('models/pelican.gltf'))

// Set the initial position and scale of the pelican
pelican.addComponent(new Transform({
  position: new Vector3(8, 1, 8),
  scale: new Vector3(0.5, 0.5, 0.5)
}))

// Add the pelican entity to the engine
engine.addEntity(pelican)


"Create a pen using a cilinder and a cone. Add Color."
const pen = new Entity()
pen.addComponent(new CylinderShape())
pen.addComponent(new Transform({ position: new Vector3(5, 1, 5) }))
pen.addComponent(new Material())
pen.getComponent(Material).albedoColor = Color3.Blue()
engine.addEntity(pen)

const color = Color3.Blue()
pen.getComponent(Material).albedoColor = color

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color3.Random()
  }
}())

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color3.Random()
  }
}())

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color3.Random()
  }
}())

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color3.Random()
  }
}())

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color3.Random()
  }
}())

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color3.Random()
  }
}())

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color3.Random()
  }
}())

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color3.Random()
  }
}())

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color3.Random()
  }
}())

engine.addSystem(new class {
  update(dt: number) {
    const pen = engine.getEntityByName("pen")
    const material = pen.getComponent(Material)
    material.albedoColor = Color


"create a sphere in the middle"
const sphere = new Entity()
sphere.addComponent(new SphereShape())
sphere.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: Vector3.One() }))
sphere.addComponent(new Material())
sphere.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(sphere)
-- A sphere has been created in the middle of the Decentraland scene 


"create a large sphere in the middle"
const largeSphere = new Entity()
largeSphere.addComponent(new SphereShape())
largeSphere.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(2, 2, 2) }))
largeSphere.addComponent(new Material())
largeSphere.getComponent(Material).albedoColor = Color3.FromHexString('#FF0000')
engine.addEntity(largeSphere)
-- A large red sphere has been created in the middle of the Decentraland scene 


"Create a pen using a cilinder and a cone. Add Color."
const c = new Entity()
c.addComponent(new CylinderShape())
c.addComponent(new Transform({
  position: new Vector3(5, 1, 5)
}))

const d = new Entity()
d.addComponent(new ConeShape())
d.addComponent(new Transform({
  position: new Vector3(5, 1, 5)
}))

const pen = new Entity()
pen.addComponent(new CylinderShape())
pen.addComponent(new Transform({
  position: new Vector3(0, 1, 0)
}))

pen.addComponent(new Material())
pen.material = new Material()
pen.material.albedoColor = Color3.FromHexString("#8B5E3C")

pen.addComponent(new Transform())
pen.getComponent(Transform).rotation = Quaternion.Euler(0, 45, 0)
engine.addEntity(pen)

pen.setParent(d)

pen.setParent(c)

pen.setParent(null)

pen.setParent(c)
pen.setParent(d)

pen.addComponent(new CylinderShape())
pen.addComponent(new Transform())
pen.getComponent(Transform).position = new Vector3(5, 1, 5)

pen.addComponent(new ConeShape())
pen.addComponent(new Transform())
pen.getComponent(Transform).position = new Vector3(5, 1, 5)

pen.addComponent(new Material())
pen.material = new Material()
pen.material.albedoColor = Color3.FromHexString("#8B5E3C")

pen.addComponent(new Transform())
pen.getComponent(Transform).rotation = Quaternion.Euler(0, 45, 0)
engine.addEntity(pen)

pen.setParent(d)

pen.setParent(c)

pen.setParent(null)

pen.setParent(c)
pen.setParent(d)

pen.addComponent(new CylinderShape())
pen.addComponent(new Transform())
pen.getComponent(Transform).position = new Vector3(0, 1, 0)

pen.addComponent(new ConeShape())
pen.addComponent(new Transform())
pen.getComponent(Transform).position = new Vector3(0, 1, 0)

pen.addComponent(new Material())
pen.material = new Material()
pen.material.albedoColor = Color3.FromHexString("#8B5E3C")

pen.addComponent(new Transform())
pen.getComponent(Transform).rotation = Quaternion.Euler(0, -45, 0)
engine.addEntity(pen)

pen.setParent(d)

pen.setParent(c)

pen.setParent(null)

pen.setParent(c)
pen.setParent(d)

pen.addComponent(new CylinderShape())
pen.addComponent(new Transform())
pen.getComponent(Transform).position = new Vector3(5, -1, 5)

pen.addComponent(new ConeShape())
pen.addComponent(new Transform())
pen.getComponent(Transform).position = new Vector3(5, -1, 5)

pen.addComponent(new Material())
pen.material = new Material()
pen.material.albedoColor = Color3.FromHexString("#8B5E3C")

pen.addComponent(new Transform())
pen.getComponent(Transform).rotation = Quaternion.Euler(0, -45, 0)
engine.addEntity(pen)

pen.setParent(d)

pen.setParent(c)

pen.setParent(null)

pen.setParent(c)
pen.setParent(d)

pen.addComponent(new CylinderShape())
pen.addComponent(new Transform())
pen.getComponent(Transform).position = new Vector3(5, 1, 5)

pen.addComponent(new ConeShape())
pen.addComponent(new Transform())
pen.getComponent(Transform).position = new Vector3(5, 1, 5)

pen.addComponent(new Material


"create a small sphere in the middle"
const smallSphere = new Entity()
smallSphere.addComponent(new SphereShape())
smallSphere.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(0.5, 0.5, 0.5) }))
smallSphere.addComponent(new Material())
smallSphere.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(smallSphere)
-- A small sphere has been created in the middle of the Decentraland scene 


"Generate a class (extends the inherent entity class) has a function that creates a new sphere object at a random location (the sphere object is parented to the class). Add 2 random functions as well."
class MyClass extends Entity {
  constructor() {
    super()
    this.addComponent(new SphereShape())
    this.addComponent(new Transform({ position: new Vector3(Math.random() * 10, 2, Math.random() * 10) }))
    this.addComponent(new OnPointerDown(() => {
      const sphere = new Sphere(Math.random() * 10, 2, Math.random() * 10)
      sphere.addComponent(new Transform({ position: this.getComponent(Transform).position }))
      sphere.getComponent(Transform).scale.setAll(0)
      sphere.getComponent(Transform).scale.setAll(Math.random() * 2 + 1)
      engine.addEntity(sphere)
    }))
  }

  generate() {
    this.addComponent(new OnPointerDown(() => {
      this.generate()
    }))
  }

  generate() {
    this.getComponent(Transform).position.y += Math.random() * 0.1 + 0.05
    this.getComponent(Transform).position.x += Math.random() * 0.1 + 0.05
    this.getComponent(Transform).position.z += Math.random() * 0.1 + 0.05
  }
}

engine.addEntity(new MyClass())

engine.addSystem(new utils.Delay(2000, () => {
  engine.addSystem(new utils.Delay(500, () => {
    engine.removeEntityByName(MyClass.name)
  }))
}))

engine.addSystem(new utils.Delay(2000, () => {
  engine.addSystem(new utils.Delay(500, () => {
    engine.removeEntityByName(MyClass.name)
  }))
}))

engine.addSystem(new utils.Delay(2000, () => {
  engine.addSystem(new utils.Delay(500, () => {
    engine.removeEntityByName(MyClass.name)
  }))
}))

engine.addSystem(new utils.Delay(2000, () => {
  engine.addSystem(new utils.Delay(500, () => {
    engine.removeEntityByName(MyClass.name)
  }))
}))

engine.addSystem(new utils.Delay(2000, () => {
  engine.addSystem(new utils.Delay(500, () => {
    engine.removeEntityByName(MyClass.name)
  }))
}))

engine.addSystem(new utils.Delay(2000, () => {
  engine.addSystem(new utils.Delay(500, () => {
    engine.removeEntityByName(MyClass.name)
  }))
}))

engine.addSystem(new utils.Delay(2000, () => {
  engine.addSystem(new utils.Delay(500, () => {
    engine.removeEntityByName(MyClass.name)
  }))
}))

engine.addSystem(new utils.Delay(2000, () => {



"create an invisible small sphere in the middle"
/** This is editor 4 */
var global_var = 10


"Build a green sphere."
// Create the sphere entity
const sphere = new Entity()
sphere.addComponentOrReplace(new Transform({
  position: new Vector3(5, 1, 5)
}))
sphere.addComponentOrReplace(new SphereShape())

engine.addEntity(sphere)

// Add the sphere to the scene
engine.addEntity(sphere)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 0
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 1
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 2
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 0
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = -1
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = -2
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = -0
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 1
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 2
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 0
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = -1
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = -2
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = -0
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 1
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 2
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = 0
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = -1
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = -2
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent(Transform).position.y = -0
  })
)

// Listen for click events
sphere.addComponent(
  new OnPointerDown(() => {
    sphere.getComponent


"Generate a class (extends the inherent entity class) has a function that creates a new sphere object at a random location (the sphere object is parented to the class)."
// Create a class that extends the inherent entity class
class Sphere {
   // Create a new sphere object at a random location
   constructor() {
      // Create a new sphere object at a random location
      this.addComponent(new GLTFShape('models/sphere.glb'))
      this.addComponent(new Transform({ position: new Vector3(Math.random() * 10, Math.random() * 10, Math.random() * 10) }))
      this.addComponent(new SphereShape())
   }
}

// Create a new sphere object at a random location
Sphere.prototype.randomLocation = function() {
   // Create a new sphere object at a random location
   this.addComponent(new GLTFShape('models/sphere.glb'))
   this.addComponent(new Transform({ position: new Vector3(Math.random() * 10, Math.random() * 10, Math.random() * 10) }))
   this.addComponent(new SphereShape())
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.createSphere = function() {
   // Add a function that creates a new sphere object at a random location to the class
   this.createSphere()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.createSphere() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.randomLocation = function() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.createSphere() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.randomLocation() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.createSphere() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.randomLocation() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.createSphere() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.randomLocation() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.createSphere() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.randomLocation() {
   // Add a function that creates a new sphere object at a random location to the class
   this.randomLocation()
   return this
}

// Add a function that creates a new sphere object at a random location to the class
Sphere.prototype.createSphere() {
   // Add a function that creates a new sphere object at a random location to the class


"create an invisible small sphere in the middle"
const invisibleSphere = new Entity()
invisibleSphere.addComponent(new SphereShape())
invisibleSphere.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(0.5, 0.5, 0.5) }))
const invisibleMaterial = new Material()
invisibleMaterial.albedoColor = new Color4(1, 1, 1, 0)
invisibleSphere.addComponent(invisibleMaterial)
engine.addEntity(invisibleSphere)
-- The sphere is now placed in the middle of the scene and is invisible due to its transparent material 


"Create a text shape with the text "Hello World"."
// Create a new TextShape
const textShape = new TextShape();

// Set the text and font size
textShape.value = "Hello World";
textShape.fontSize = 3;

// Create a new Entity for the TextShape
const textEntity = new Entity();
textEntity.addComponent(textShape);

// Set the position of the Text Entity
textEntity.position.set(0, 2, 0);

// Add the Text Entity to the scene
engine.addEntity(textEntity);

// Add a click event to the Text Entity
textEntity.addComponent(
  new OnClick(() => {
    textEntity.getComponent(TextShape).value = "Goodbye World";
  })
);

// Create a new TextShape with the text "Goodbye World"
const goodbyeWorldShape = new TextShape("Goodbye World");
goodbyeWorldShape.value = "Goodbye World";
goodbyeWorldShape.fontSize = 3;

// Create a new Entity for the TextShape
const goodbyeWorldEntity = new Entity();
goodbyeWorldEntity.addComponent(goodbyeWorldShape);

// Set the position of the Text Entity
goodbyeWorldEntity.position.set(0, 2, 0);

// Add the Text Entity to the scene
engine.addEntity(goodbyeWorldEntity);

// Add a click event to the Text Entity
goodbyeWorldEntity.addComponent(
  new OnClick(() => {
    goodbyeWorldEntity.getComponent(TextShape).value = "Hello World";
  })
);

// Create a new TextShape with the text "Hello World"
const helloWorldShape = new TextShape("Hello World");
helloWorldShape.value = "Hello World";
helloWorldShape.fontSize = 3;

// Create a new Entity for the TextShape
const helloWorldEntity = new Entity();
helloWorldEntity.addComponent(helloWorldShape);

// Set the position of the Text Entity
helloWorldEntity.position.set(0, 2, 0);

// Add the Text Entity to the scene
engine.addEntity(helloWorldEntity);

// Add a click event to the Text Entity
helloWorldEntity.addComponent(
  new OnClick(() => {
    helloWorldEntity.getComponent(TextShape).value = "Goodbye World";
  })
);

// Create a new TextShape with the text "Goodbye World"
const goodbyeWorldShape = new TextShape("Goodbye World");
goodbyeWorldShape.value = "Goodbye World";
goodbyeWorldShape.fontSize = 3;

// Create a new Entity for the TextShape
const goodbyeWorldEntity = new Entity();
goodbyeWorldEntity.addComponent(goodbyeWorldShape);

// Set the position of the Text Entity
goodbyeWorldEntity.position.set(0, 2, 0);

// Add the Text Entity to the scene
engine.addEntity(goodbyeWorldEntity);

// Add a click event to the Text Entity
goodbyeWorldEntity.addComponent(
  new OnClick(() => {
    goodbyeWorldEntity.getComponent(TextShape).value = "Hello World";
  })
);

// Create a new TextShape with the text "Hello World"
const helloWorldShape = new TextShape("Hello World");
helloWorldShape.value = "Hello World";
helloWorldShape.fontSize = 3;

// Create a new Entity for the TextShape
const helloWorldEntity = new Entity();
helloWorldEntity.addComponent(helloWorldShape);

// Set the position of the Text Entity
helloWorldEntity.position.set(0, 2, 0);

// Add the Text Entity to the scene
engine.addEntity(helloWorldEntity);

// Add a click event to the Text Entity
helloWorldEntity.addComponent(
  new OnClick(() => {
    helloWorldEntity.getComponent(TextShape).value = "Goodbye World";
  })
);

// Create a new TextShape with the text "Goodbye World"
const goodbyeWorldShape = new TextShape("Goodbye World");
goodbyeWorldShape.value = "Goodbye World";
goodbyeWorldShape.fontSize = 3;

// Create a new Entity for the TextShape
const goodbyeWorldEntity = new Entity();
goodbyeWorldEntity.addComponent(goodbyeWorldShape);

// Set the position of


"create a red small sphere in the middle"
/** This is editor 4 */
var global_var = 10


"Generate a class (extends the inherent entity class) has a function that creates a new sphere object at a random location (the sphere object is parented to the class)."
-- DCLBuilderAI: Creating a class that extends the Entity class and has a function to create a new sphere object at a random location. The sphere object is parented to the class. 

class RandomSphere extends Entity {
  constructor() {
    super()
    this.addComponent(new Transform())
    this.spawnSphere()
  }

  spawnSphere() {
    const sphere = new Entity()
    sphere.setParent(this)
    sphere.addComponent(new SphereShape())
    sphere.addComponent(new Transform({
      position: new Vector3(Math.random() * 10, Math.random() * 10, Math.random() * 10),
      scale: Vector3.One()
    }))
    sphere.addComponent(new Material())
    sphere.getComponent(Material).albedoColor = Color3.Random()
    engine.addEntity(sphere)
  }
}

-- Usage: 
const myRandomSphere = new RandomSphere()
engine.addEntity(myRandomSphere)


"create a red small sphere in the middle"
const redSphere = new Entity()
redSphere.addComponent(new SphereShape())
redSphere.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(0.5, 0.5, 0.5) }))
const redSphereMaterial = new Material()
redSphereMaterial.albedoColor = Color3.Red()
redSphere.addComponent(redSphereMaterial)
engine.addEntity(redSphere)
-- A small red sphere has been created in the middle of the Decentraland scene 


"Generate a class (extends the inherent entity class) has a function that creates a new sphere object at a random location (the sphere object is parented to the class)."
/** This is editor 4 */
var global_var = 10


"create a red small box in the middle"
/** This is editor 4 */
var global_var = 10


"create a red small box in the middle"
const redBox = new Entity()
redBox.addComponent(new BoxShape())
redBox.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(0.5, 0.5, 0.5) }))
const redMaterial = new Material()
redMaterial.albedoColor = Color3.Red()
redBox.addComponent(redMaterial)
engine.addEntity(redBox)
-- A small red box has been created in the middle of the Decentraland scene 


"Generate a class (extends the inherent entity class) has a function that creates a new object at a random location (the object is parented to the class). object models should be taken at random from[]"
-- Create a class that extends the inherent Entity class and has a function to create a new object at a random location. Object models should be taken at random from an array in Decentraland. 

class RandomObjectSpawner extends Entity {
  constructor() {
    super()
    engine.addEntity(this)
  }

  spawnRandomObject(modelsArray: GLTFShape[]) {
    const randomModel = modelsArray[Math.floor(Math.random() * modelsArray.length)]
    const randomPosition = new Vector3(Math.random() * 10, 0, Math.random() * 10)

    const newObject = new Entity()
    newObject.addComponent(randomModel)
    newObject.addComponent(new Transform({ position: randomPosition, scale: Vector3.One() }))
    newObject.setParent(this)

    engine.addEntity(newObject)
  }
}

-- Example usage: 
const modelsArray = [
  new GLTFShape('models/model1.glb'),
  new GLTFShape('models/model2.glb'),
  new GLTFShape('models/model3.glb')
]

const spawner = new RandomObjectSpawner()
spawner.spawnRandomObject(modelsArray)


"Add a text shape, with text "0", and a cube. When I click the cube a counter is updated and displayed on the text shape."
const counterText = new TextShape('0')
const counterEntity = new Entity()
counterEntity.addComponent(counterText)
counterEntity.addComponent(new Transform({ position: new Vector3(1, 2, 1) }))
engine.addEntity(counterEntity)

let counter = 0

const cube = new Entity()
cube.addComponent(new BoxShape())
cube.addComponent(new Transform({ position: new Vector3(1, 1, 1), scale: new Vector3(1, 1, 1) }))
cube.addComponent(new Material())
cube.getComponent(Material).albedoColor = Color3.Red()
engine.addEntity(cube)

cube.addComponent(
  new OnClick(() => {
    counter++
    counterText.value = counter.toString()
  })
)
-- The cube is now clickable and updates the counter displayed on the text shape. 


"create a red small plane in the middle"
/** This is editor 4 */
var global_var = 10


"Add a text shape, with text "0", and a cube. When I click the cube a counter is updated and displayed on the text shape."
/** This is editor 4 */
var global_var = 10


"create a red small plane in the middle"
const redPlane = new Entity()
redPlane.addComponent(new PlaneShape())
redPlane.addComponent(new Transform({ position: new Vector3(8, 0, 8), scale: new Vector3(1, 1, 1) }))
const redMaterial = new Material()
redMaterial.albedoColor = Color3.Red()
redPlane.addComponent(redMaterial)
engine.addEntity(redPlane)
-- A red small plane has been created at the center of the Decentraland scene 


"Generate a class (extends the inherent entity class) has a function that creates a new object (randomly selected from array) at a random location (the object is parented to the class)"
-- Generate a class (extends the inherent entity class) has a function that creates a new object (randomly selected from array) at a random location (the object is parented to the class) in decentraland 

class RandomObjectSpawner extends Entity {
  constructor() {
    super()
    engine.addEntity(this)
  }

  spawnRandomObject() {
    const objectArray = [
      new BoxShape(),
      new SphereShape(),
      new CylinderShape(),
      new PlaneShape(),
      new ConeShape()
    ]

    const randomObject = objectArray[Math.floor(Math.random() * objectArray.length)]
    const randomPosition = new Vector3(
      Math.random() * 8 + 1,
      Math.random() * 2 + 0.5,
      Math.random() * 8 + 1
    )

    const newEntity = new Entity()
    newEntity.addComponent(randomObject)
    newEntity.addComponent(new Transform({ position: randomPosition }))
    newEntity.addComponent(new Material())
    newEntity.getComponent(Material).albedoColor = Color3.Random()
    newEntity.setParent(this)
    engine.addEntity(newEntity)
  }
}

const randomObjectSpawner = new RandomObjectSpawner()
randomObjectSpawner.spawnRandomObject()


"create a red small avocado in the middle"
const redAvocado = new Entity()
redAvocado.addComponent(new GLTFShape('models/Avocado.glb'))
redAvocado.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(0.5, 0.5, 0.5) }))

const redMaterial = new Material()
redMaterial.albedoColor = new Color3(1, 0, 0)
redAvocado.addComponent(redMaterial)

engine.addEntity(redAvocado)
-- A small red avocado has been placed in the middle of the scene in Decentraland 


"Generate a class (extends the inherent entity class) has a function that creates a new object (randomly selected from array) at a random location (the object is parented to the class)"
class RandomObjectSpawner extends Entity {
  constructor() {
    super()
    engine.addEntity(this)
  }

  spawnRandomObject() {
    const objects = ['BoxShape', 'CylinderShape', 'PlaneShape', 'SphereShape']
    const randomIndex = Math.floor(Math.random() * objects.length)
    const randomShape = objects[randomIndex]

    const newEntity = new Entity()
    newEntity.setParent(this)
    newEntity.addComponent(new Transform({
      position: new Vector3(Math.random() * 10, Math.random() * 10, Math.random() * 10),
      scale: Vector3.One()
    }))

    switch (randomShape) {
      case 'BoxShape':
        newEntity.addComponent(new BoxShape())
        break
      case 'CylinderShape':
        newEntity.addComponent(new CylinderShape())
        break
      case 'PlaneShape':
        newEntity.addComponent(new PlaneShape())
        break
      case 'SphereShape':
        newEntity.addComponent(new SphereShape())
        break
    }

    newEntity.addComponent(new Material())
    newEntity.getComponent(Material).albedoColor = Color3.Random()
    engine.addEntity(newEntity)
  }
}

-- Usage example: 
const spawner = new RandomObjectSpawner()
spawner.spawnRandomObject()


"Add a sphere that slowly moves to the player. If the player clicks on the sphere, the sphere is moved to a random location."
const player = Camera.instance
const sphere = new Entity()
sphere.addComponent(new SphereShape())
sphere.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
sphere.addComponent(new Material())
sphere.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(sphere)

const moveSphereToRandomPosition = () => {
  const randomPosition = new Vector3(Math.random() * 10, 1, Math.random() * 10)
  sphere.getComponent(Transform).position = randomPosition
}

sphere.addComponent(
  new OnClick(() => {
    moveSphereToRandomPosition()
  })
)

class SphereFollowSystem implements ISystem {
  update(dt: number) {
    const targetPosition = player.position.clone()
    targetPosition.y = 1
    const currentPosition = sphere.getComponent(Transform).position.clone()
    const direction = targetPosition.subtract(currentPosition).normalize()
    const newPosition = currentPosition.add(direction.scale(0.05))
    sphere.getComponent(Transform).position = newPosition
  }
}

engine.addSystem(new SphereFollowSystem())


"Add a sphere that slowly moves to the player. If the player clicks on the sphere, the sphere is moved to a random location."
const sphere = new Entity()
sphere.addComponent(new SphereShape())
sphere.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
sphere.addComponent(new Material())
sphere.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(sphere)

const player = Camera.instance

sphere.addComponent(new utils.FollowPathComponent(player, 0.5, 0.1))

sphere.addComponent(new OnClick(() => {
  const randomPosition = new Vector3(Math.random() * 10, 1, Math.random() * 10)
  sphere.getComponent(Transform).position = randomPosition
}))



"Generate a class (extends the inherent entity class) has a function that creates a new object at a random location (the object is parented to the class)"
class RandomObjectSpawner extends Entity {
  constructor() {
    super()
    engine.addEntity(this)
  }

  spawnRandomObject() {
    const newObject = new Entity()
    newObject.setParent(this)
    newObject.addComponent(new BoxShape())
    newObject.addComponent(new Transform({
      position: new Vector3(Math.random() * 10, Math.random() * 10, Math.random() * 10),
      scale: Vector3.One()
    }))
    newObject.addComponent(new Material())
    newObject.getComponent(Material).albedoColor = Color3.Random()
    engine.addEntity(newObject)
  }
}

const randomSpawner = new RandomObjectSpawner()
randomSpawner.spawnRandomObject()


"create a red small avocado in the middle"
/** This is editor 4 */
var global_var = 10


"Add a sphere that slowly moves to the player. If the player clicks on the sphere, the sphere is moved to a random location."
/** This is editor 4 */
var global_var = 10


"Generate a class (extends the inherent entity class) has a function that creates a new object at a random location (the object is parented to the class)"
/** This is editor 4 */
var global_var = 10


"create a red small avocado in the middle with parent green box entity"
const greenBox = new Entity()
greenBox.addComponent(new BoxShape())
greenBox.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(2, 2, 2) }))
const greenBoxMaterial = new Material()
greenBoxMaterial.albedoColor = Color3.Green()
greenBox.addComponent(greenBoxMaterial)
engine.addEntity(greenBox)

const smallAvocado = new Entity()
smallAvocado.addComponent(new GLTFShape('models/Avocado.glb'))
smallAvocado.addComponent(new Transform({ position: new Vector3(0, 0.5, 0), scale: new Vector3(0.5, 0.5, 0.5) }))
const smallAvocadoMaterial = new Material()
smallAvocadoMaterial.albedoColor = Color3.Red()
smallAvocado.addComponent(smallAvocadoMaterial)
smallAvocado.setParent(greenBox)
engine.addEntity(smallAvocado)


"Generate a class that moves a sphere object between 8 random locations in the scene"
class SphereMover {
  private sphere: Entity
  private locations: Vector3[]

  constructor() {
    this.sphere = new Entity()
    this.sphere.addComponent(new SphereShape())
    this.sphere.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
    this.sphere.addComponent(new Material())
    this.sphere.getComponent(Material).albedoColor = Color3.Random()
    engine.addEntity(this.sphere)

    this.locations = [
      new Vector3(1, 1, 1),
      new Vector3(1, 1, 9),
      new Vector3(9, 1, 1),
      new Vector3(9, 1, 9),
      new Vector3(1, 1, 5),
      new Vector3(5, 1, 1),
      new Vector3(9, 1, 5),
      new Vector3(5, 1, 9),
    ]

    this.moveSphere()
  }

  private moveSphere() {
    const targetLocation = this.locations[Math.floor(Math.random() * this.locations.length)]
    this.sphere.getComponent(Transform).position = targetLocation
  }
}

const sphereMover = new SphereMover()


"Create a tree using shapes."
const treeTrunk = new Entity()
treeTrunk.addComponent(new CylinderShape())
treeTrunk.addComponent(new Transform({ position: new Vector3(2, 1, 2), scale: new Vector3(0.5, 2, 0.5) }))
treeTrunk.addComponent(new Material())
treeTrunk.getComponent(Material).albedoColor = new Color3(0.6, 0.4, 0.2)
engine.addEntity(treeTrunk)

const treeLeaves = new Entity()
treeLeaves.addComponent(new SphereShape())
treeLeaves.addComponent(new Transform({ position: new Vector3(2, 3, 2), scale: new Vector3(1.5, 1.5, 1.5) }))
treeLeaves.addComponent(new Material())
treeLeaves.getComponent(Material).albedoColor = new Color3(0.1, 0.5, 0.1)
engine.addEntity(treeLeaves)

-- This code creates a simple tree using a cylinder for the trunk and a sphere for the leaves. The tree is placed at position (2, 0, 2) in the scene. 


"Create a tree using shapes."
const treeTrunk = new Entity()
treeTrunk.addComponent(new CylinderShape())
treeTrunk.addComponent(new Transform({ position: new Vector3(2, 0.5, 2), scale: new Vector3(0.5, 1, 0.5) }))
treeTrunk.addComponent(new Material())
treeTrunk.getComponent(Material).albedoColor = new Color3(0.55, 0.27, 0.07)
engine.addEntity(treeTrunk)

const treeLeaves = new Entity()
treeLeaves.addComponent(new SphereShape())
treeLeaves.addComponent(new Transform({ position: new Vector3(2, 2, 2), scale: new Vector3(1.5, 1.5, 1.5) }))
treeLeaves.addComponent(new Material())
treeLeaves.getComponent(Material).albedoColor = new Color3(0.13, 0.54, 0.13)
engine.addEntity(treeLeaves)

-- This code creates a simple tree using a cylinder for the trunk and a sphere for the leaves. Adjust the position and scale values to customize the tree. 


"Generate a system that moves an object between 2 points in real-time"
-- DCLBuilderAI generated code for a system that moves an object between 2 points in real-time in Decentraland 

@Component('moveBetweenPoints')
class MoveBetweenPoints {
  pointA: Vector3
  pointB: Vector3
  speed: number
  fraction: number = 0

  constructor(pointA: Vector3, pointB: Vector3, speed: number) {
    this.pointA = pointA
    this.pointB = pointB
    this.speed = speed
  }
}

const movingEntity = new Entity()
movingEntity.addComponent(new BoxShape())
movingEntity.addComponent(new Transform({ position: new Vector3(1, 1, 1) }))
movingEntity.addComponent(new MoveBetweenPoints(new Vector3(1, 1, 1), new Vector3(5, 1, 5), 1))
engine.addEntity(movingEntity)

class MoveSystem implements ISystem {
  update(dt: number) {
    const entities = engine.getComponentGroup(MoveBetweenPoints)
    for (const entity of entities.entities) {
      const moveComponent = entity.getComponent(MoveBetweenPoints)
      moveComponent.fraction += dt * moveComponent.speed

      if (moveComponent.fraction > 1) {
        moveComponent.fraction = 0
      }

      const newPosition = Vector3.Lerp(moveComponent.pointA, moveComponent.pointB, moveComponent.fraction)
      entity.getComponent(Transform).position = newPosition
    }
  }
}

engine.addSystem(new MoveSystem())


"Generate a class that displays a video from a given URL"
-- DCLBuilderAI generated code for displaying a video from a given URL in Decentraland 

class VideoDisplay {
  constructor(videoURL) {
    this.videoURL = videoURL
    this.createVideoDisplay()
  }

  createVideoDisplay() {
    const videoTexture = new VideoTexture(new VideoClip(this.videoURL))
    const videoMaterial = new Material()
    videoMaterial.albedoTexture = videoTexture

    const videoScreen = new Entity()
    videoScreen.addComponent(new PlaneShape())
    videoScreen.addComponent(new Transform({ position: new Vector3(8, 4, 8), scale: new Vector3(5, 3, 1), rotation: Quaternion.Euler(0, 180, 0) }))
    videoScreen.addComponent(videoMaterial)
    engine.addEntity(videoScreen)

    videoTexture.playing = true
    videoTexture.loop = true
  }
}

-- Example usage 
const myVideoDisplay = new VideoDisplay('https://myvideourl.com/video.mp4')


"Create a tree using 3 shapes."
const treeTrunk = new Entity()
treeTrunk.addComponent(new CylinderShape())
treeTrunk.addComponent(new Transform({ position: new Vector3(1, 0.5, 1), scale: new Vector3(0.5, 1, 0.5) }))
treeTrunk.addComponent(new Material())
treeTrunk.getComponent(Material).albedoColor = Color3.FromHexString('#8B4513')
engine.addEntity(treeTrunk)

const treeLeaves1 = new Entity()
treeLeaves1.addComponent(new SphereShape())
treeLeaves1.addComponent(new Transform({ position: new Vector3(1, 2, 1), scale: new Vector3(1.5, 1.5, 1.5) }))
treeLeaves1.addComponent(new Material())
treeLeaves1.getComponent(Material).albedoColor = Color3.FromHexString('#228B22')
engine.addEntity(treeLeaves1)

const treeLeaves2 = new Entity()
treeLeaves2.addComponent(new SphereShape())
treeLeaves2.addComponent(new Transform({ position: new Vector3(1, 3, 1), scale: new Vector3(1.25, 1.25, 1.25) }))
treeLeaves2.addComponent(new Material())
treeLeaves2.getComponent(Material).albedoColor = Color3.FromHexString('#228B22')
engine.addEntity(treeLeaves2)

const treeLeaves3 = new Entity()
treeLeaves3.addComponent(new SphereShape())
treeLeaves3.addComponent(new Transform({ position: new Vector3(1, 4, 1), scale: new Vector3(1, 1, 1) }))
treeLeaves3.addComponent(new Material())
treeLeaves3.getComponent(Material).albedoColor = Color3.FromHexString('#228B22')
engine.addEntity(treeLeaves3)

-- This code creates a tree using 3 shapes: a cylinder for the trunk and 3 spheres for the leaves. The tree is placed at position (1, 0, 1) in the scene. 


"Create a tree using 3 box shapes."
const treeTrunk = new Entity()
treeTrunk.addComponent(new BoxShape())
treeTrunk.addComponent(new Transform({ position: new Vector3(2, 0.5, 2), scale: new Vector3(0.5, 1, 0.5) }))
treeTrunk.addComponent(new Material())
treeTrunk.getComponent(Material).albedoColor = new Color3(0.55, 0.27, 0.07)
engine.addEntity(treeTrunk)

const treeLeaves1 = new Entity()
treeLeaves1.addComponent(new BoxShape())
treeLeaves1.addComponent(new Transform({ position: new Vector3(2, 2, 2), scale: new Vector3(2, 2, 2) }))
treeLeaves1.addComponent(new Material())
treeLeaves1.getComponent(Material).albedoColor = new Color3(0, 0.5, 0)
engine.addEntity(treeLeaves1)

const treeLeaves2 = new Entity()
treeLeaves2.addComponent(new BoxShape())
treeLeaves2.addComponent(new Transform({ position: new Vector3(2, 3.5, 2), scale: new Vector3(1.5, 1.5, 1.5) }))
treeLeaves2.addComponent(new Material())
treeLeaves2.getComponent(Material).albedoColor = new Color3(0, 0.5, 0)
engine.addEntity(treeLeaves2)

const treeLeaves3 = new Entity()
treeLeaves3.addComponent(new BoxShape())
treeLeaves3.addComponent(new Transform({ position: new Vector3(2, 4.5, 2), scale: new Vector3(1, 1, 1) }))
treeLeaves3.addComponent(new Material())
treeLeaves3.getComponent(Material).albedoColor = new Color3(0, 0.5, 0)
engine.addEntity(treeLeaves3)

-- This code creates a tree using 3 box shapes in Decentraland. The tree has a trunk and three levels of leaves. 


"create an NFT from the collection Decentraland Sweatshirt with a border rotating clockwise"
const NFTCollection = "Decentraland Sweatshirt"
const NFTId = "1" // Replace with the specific NFT ID from the collection

const nftEntity = new Entity()
nftEntity.addComponent(new NFTShape(`ethereum://${NFTCollection}/${NFTId}`))
nftEntity.addComponent(new Transform({ position: new Vector3(8, 1, 8) }))
engine.addEntity(nftEntity)

const borderEntity = new Entity()
borderEntity.addComponent(new PlaneShape())
borderEntity.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(1.1, 1.1, 1.1) }))
borderEntity.addComponent(new Material())
borderEntity.getComponent(Material).albedoColor = Color3.Black()
engine.addEntity(borderEntity)

class RotatorSystem implements ISystem {
  update(dt: number) {
    const rotationSpeed = 45 // degrees per second
    const rotationAngle = (rotationSpeed * dt) % 360
    borderEntity.getComponent(Transform).rotate(Vector3.Up(), rotationAngle)
  }
}

engine.addSystem(new RotatorSystem())


"Generate an object that moves between 2 locations"
const movingObject = new Entity()
movingObject.addComponent(new BoxShape())
movingObject.addComponent(new Transform({ position: new Vector3(1, 1, 1), scale: Vector3.One() }))
movingObject.addComponent(new Material())
movingObject.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(movingObject)

const startPosition = new Vector3(1, 1, 1)
const endPosition = new Vector3(10, 1, 10)
let direction = 1

const moveObject = () => {
  const currentPosition = movingObject.getComponent(Transform).position
  const newPosition = Vector3.Lerp(currentPosition, direction > 0 ? endPosition : startPosition, 0.05)

  movingObject.getComponent(Transform).position = newPosition

  if (Vector3.Distance(newPosition, direction > 0 ? endPosition : startPosition) < 0.1) {
    direction *= -1
  }
}

engine.addSystem(new class {
  update(dt: number) {
    moveObject()
  }
})
-- This code creates a moving object that alternates between two locations in Decentraland. 


"Create a board that displays the player name."
const playerNameBoard = new Entity()
playerNameBoard.addComponent(new PlaneShape())
playerNameBoard.addComponent(new Transform({ position: new Vector3(8, 2, 8), scale: new Vector3(2, 1, 1) }))
playerNameBoard.addComponent(new Material())
playerNameBoard.getComponent(Material).albedoColor = Color3.White()

const playerNameText = new TextShape()
playerNameText.value = 'Player Name: ' + executeTask(async () => {
  const userData = await getUserData()
  return userData.displayName
})
playerNameText.color = Color3.Black()
playerNameText.fontSize = 2

const playerNameTextEntity = new Entity()
playerNameTextEntity.addComponent(playerNameText)
playerNameTextEntity.addComponent(new Transform({ position: new Vector3(8, 2, 8.01) }))
playerNameTextEntity.setParent(playerNameBoard)

engine.addEntity(playerNameBoard)
engine.addEntity(playerNameTextEntity)
-- The code above creates a board that displays the player's name in Decentraland. 


"Create a board that displays the player name."
function createBoard() {
  const board = new Entity('board')
  engine.addEntity(board)
  return board
}

const board = createBoard();

//Add a Text component to the board Entity
const nameText = new Text(board)
nameText.value = "Player 1"
nameText.fontSize = 20
nameText.color = Color4.White()
board.addComponent(nameText)

//Add a Text component to the board Entity
const scoreText = new Text(board)
scoreText.value = "Score: 0"
scoreText.fontSize = 20
scoreText.color = Color4.White()
board.addComponent(scoreText)

//Add a Text component to the board Entity
const livesText = new Text(board)
livesText.value = "Lives: 3"
livesText.fontSize = 20
livesText.color = Color4.White()
board.addComponent(livesText)

//Add a Board Entity to the scene
engine.addEntity(new Board())

//Add an update function to the Board Entity
board.addComponent(
  new class {
    update(dt: number) {
      if (Input.isKeyDown("space")) {
        //Add player score
        score += 1
        scoreText.value = "Score: " + score
        lives -= 1
        livesText.value = "Lives: " + lives
        if (lives === 0) {
          //Add lives
          livesText.value = "Lives: " + lives + " " + playerName
          livesText.fontSize = 20
          livesText.color = Color4.White()
        }
      }
    }
   }
)
)

//Add a Score Entity to the scene
engine.addEntity(new Score())

//Add an update function to the Score Entity
score.addComponent(
  new class {
    update(dt: number) {
      scoreText.value = "Score: " + score
    }
  }
)

//Add a Lives Entity to the scene
engine.addEntity(new Lives())

//Add an update function to the Lives Entity
lives.addComponent(
  new class {
    update(dt: number) {
      livesText.value = "Lives: " + lives
    }
  }
)

//Add a Player Name Entity to the scene
engine.addEntity(new PlayerName())

//Add an update function to the Player Name Entity
playerName.addComponent(
  new class {
    update(dt: number) {
      playerNameText.value = "Player Name: " + playerName
    }
  }
)

//Add a Lives Text Entity to the scene
engine.addEntity(new LivesText())

//Add an update function to the Lives Text Entity
livesText.addComponent(
  new class {
    update(dt: number) {
      livesText.value


"Generate a class that implements the Update function to move an object between 2 locations"
class ObjectMover implements ISystem {
  private entity: Entity
  private startPosition: Vector3
  private endPosition: Vector3
  private speed: number
  private direction: Vector3

  constructor(entity: Entity, startPosition: Vector3, endPosition: Vector3, speed: number) {
    this.entity = entity
    this.startPosition = startPosition
    this.endPosition = endPosition
    this.speed = speed
    this.direction = endPosition.subtract(startPosition).normalize()
  }

  update(dt: number): void {
    const transform = this.entity.getComponent(Transform)
    const moveDistance = this.speed * dt
    const newPosition = transform.position.add(this.direction.scale(moveDistance))

    if (Vector3.DistanceSquared(newPosition, this.startPosition) > Vector3.DistanceSquared(this.endPosition, this.startPosition)) {
      newPosition.copyFrom(this.startPosition)
    }

    transform.position.copyFrom(newPosition)
  }
}

-- Usage example:
const movingEntity = new Entity()
movingEntity.addComponent(new BoxShape())
movingEntity.addComponent(new Transform({ position: new Vector3(1, 1, 1) }))
engine.addEntity(movingEntity)

const startPosition = new Vector3(1, 1, 1)
const endPosition = new Vector3(10, 1, 1)
const speed = 1
engine.addSystem(new ObjectMover(movingEntity, startPosition, endPosition, speed))



"Create a board that displays the player name."
const playerNameBoard = new Entity()
const playerNameTextShape = new TextShape('Player Name: ' + engine.getUserData().displayName)
playerNameBoard.addComponent(playerNameTextShape)
playerNameBoard.addComponent(new Transform({ position: new Vector3(8, 2, 8) }))
engine.addEntity(playerNameBoard)
playerNameTextShape.fontSize = 3
playerNameTextShape.color = Color3.White()
playerNameTextShape.hTextAlign = 'center'
playerNameTextShape.vTextAlign = 'center'
-- The board displays the player's name at position (8, 2, 8) in the scene 


"create an NFT from the collection Decentraland Hoodie with a border rotating clockwise"
const nftEntity = new Entity()
nftEntity.addComponent(new NFTShape('ethereum://0x.../0'))
nftEntity.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(1, 1, 1) }))
engine.addEntity(nftEntity)

const borderEntity = new Entity()
borderEntity.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(1.1, 1.1, 0.01) }))
borderEntity.addComponent(new BoxShape())
const borderMaterial = new Material()
borderMaterial.albedoColor = Color4.FromHexString('#FFD700')
borderEntity.addComponent(borderMaterial)
engine.addEntity(borderEntity)

class RotatorSystem implements ISystem {
  update(dt: number) {
    const rotationSpeed = 10
    borderEntity.getComponent(Transform).rotate(Vector3.Up(), dt * rotationSpeed)
  }
}

engine.addSystem(new RotatorSystem())
-- This code creates an NFT from the Decentraland Hoodie collection and adds a border around it that rotates clockwise. 


"create an NFT from the collection Decentraland Hoodie with a border rotating clockwise"
const nft = new NFTShape("ethereum://0x7c99d5e42d2e2471a0e2d5a3e1f8c7e45e298414/1")
const nftEntity = new Entity()
nftEntity.addComponent(nft)
nftEntity.addComponent(new Transform({ position: new Vector3(8, 1, 8) }))
engine.addEntity(nftEntity)

const border = new Entity()
border.addComponent(new PlaneShape())
border.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(1.1, 1.1, 1.1) }))
border.addComponent(new Material())
border.getComponent(Material).albedoColor = Color4.Black()
border.getComponent(Material).transparencyMode = 2
engine.addEntity(border)

class RotatingSystem implements ISystem {
  update(dt: number) {
    const rotationSpeed = 45 // degrees per second
    const rotationAngle = (rotationSpeed * dt) % 360
    border.getComponent(Transform).rotate(Vector3.Up(), rotationAngle)
  }
}

engine.addSystem(new RotatingSystem())


"Create a board that displays the player name."
/** This is editor 4 */
var global_var = 10


"Recreate the Pizza Tower using 4 cilinders."
const pizzaTower = new Entity()
engine.addEntity(pizzaTower)

-- Base cylinder 
const baseCylinder = new CylinderShape()
baseCylinder.radiusTop = 4
baseCylinder.radiusBottom = 4
baseCylinder.height = 1
baseCylinder.arc = 360

-- Tower cylinders 
const towerCylinder = new CylinderShape()
towerCylinder.radiusTop = 2
towerCylinder.radiusBottom = 2
towerCylinder.height = 10
towerCylinder.arc = 360

-- Create four tower entities with the towerCylinder shape 
for (let i = 0; i < 4; i++) {
  const tower = new Entity()
  tower.addComponent(towerCylinder)
  tower.addComponent(new Transform())
  tower.addComponent(new Material())
  tower.getComponent(Material).albedoColor = Color3.Random()
  pizzaTower.addChild(tower)
}

-- Position the four tower entities 
pizzaTower.children[0].getComponent(Transform).position.set(-2, 5.5, -2)
pizzaTower.children[1].getComponent(Transform).position.set(2, 5.5, -2)
pizzaTower.children[2].getComponent(Transform).position.set(-2, 5.5, 2)
pizzaTower.children[3].getComponent(Transform).position.set(2, 5.5, 2)

-- Create base entity with the baseCylinder shape 
const base = new Entity()
base.addComponent(baseCylinder)
base.addComponent(new Transform({ position: new Vector3(0, 0.5, 0) }))
base.addComponent(new Material())
base.getComponent(Material).albedoColor = Color3.Random()
pizzaTower.addChild(base)


"Recreate the Pizza Tower using 4 cilinders."
-- Creating the Pizza Tower using 4 cylinders in Decentraland 

const scene = new Entity()
scene.addComponent(new GLTFShape('models/scene.gltf'))
scene.addComponent(new Transform({ position: new Vector3(0, 0, 0) }))
engine.addEntity(scene)

const cylinder1 = new Entity()
cylinder1.addComponent(new CylinderShape())
cylinder1.addComponent(new Transform({ position: new Vector3(2, 0, 2), scale: new Vector3(1, 4, 1) }))
cylinder1.addComponent(new Material())
cylinder1.getComponent(Material).albedoColor = new Color3(1, 0, 0)
engine.addEntity(cylinder1)

const cylinder2 = new Entity()
cylinder2.addComponent(new CylinderShape())
cylinder2.addComponent(new Transform({ position: new Vector3(2, 0, -2), scale: new Vector3(1, 4, 1) }))
cylinder2.addComponent(new Material())
cylinder2.getComponent(Material).albedoColor = new Color3(0, 1, 0)
engine.addEntity(cylinder2)

const cylinder3 = new Entity()
cylinder3.addComponent(new CylinderShape())
cylinder3.addComponent(new Transform({ position: new Vector3(-2, 0, 2), scale: new Vector3(1, 4, 1) }))
cylinder3.addComponent(new Material())
cylinder3.getComponent(Material).albedoColor = new Color3(0, 0, 1)
engine.addEntity(cylinder3)

const cylinder4 = new Entity()
cylinder4.addComponent(new CylinderShape())
cylinder4.addComponent(new Transform({ position: new Vector3(-2, 0, -2), scale: new Vector3(1, 4, 1) }))
cylinder4.addComponent(new Material())
cylinder4.getComponent(Material).albedoColor = new Color3(1, 1, 0)
engine.addEntity(cylinder4)

-- Pizza Tower created using 4 cylinders in Decentraland 


"Recreate the Pizza Tower using 4 cilinders."
const pizzaTower = new Entity()
engine.addEntity(pizzaTower)

const cylinder1 = new Entity()
cylinder1.addComponent(new CylinderShape())
cylinder1.addComponent(new Transform({ position: new Vector3(0, 0, 0), scale: new Vector3(1, 10, 1) }))
cylinder1.addComponent(new Material())
cylinder1.getComponent(Material).albedoColor = Color3.FromHexString('#FFA500')
pizzaTower.addChild(cylinder1)

const cylinder2 = new Entity()
cylinder2.addComponent(new CylinderShape())
cylinder2.addComponent(new Transform({ position: new Vector3(1, 0, 0), scale: new Vector3(1, 10, 1) }))
cylinder2.addComponent(new Material())
cylinder2.getComponent(Material).albedoColor = Color3.FromHexString('#FFA500')
pizzaTower.addChild(cylinder2)

const cylinder3 = new Entity()
cylinder3.addComponent(new CylinderShape())
cylinder3.addComponent(new Transform({ position: new Vector3(1, 0, 1), scale: new Vector3(1, 10, 1) }))
cylinder3.addComponent(new Material())
cylinder3.getComponent(Material).albedoColor = Color3.FromHexString('#FFA500')
pizzaTower.addChild(cylinder3)

const cylinder4 = new Entity()
cylinder4.addComponent(new CylinderShape())
cylinder4.addComponent(new Transform({ position: new Vector3(0, 0, 1), scale: new Vector3(1, 10, 1) }))
cylinder4.addComponent(new Material())
cylinder4.getComponent(Material).albedoColor = Color3.FromHexString('#FFA500')
pizzaTower.addChild(cylinder4)

-- The Pizza Tower is created using 4 cylinders 


"Generate a script that can read data from a json file"
-- DCLBuilderAI: Reading data from a JSON file in Decentraland 

import { loadJSON } from '@decentraland/JsonUtilities'

async function readJSONData() {
  const jsonURL = 'https://example.com/myData.json'

  try {
    const jsonData = await loadJSON(jsonURL)
    console.log('JSON data:', jsonData)
  } catch (error) {
    console.error('Error loading JSON data:', error)
  }
}

readJSONData()
-- Note: Replace the 'https://example.com/myData.json' with the actual URL of your JSON file 


"Generate a script that can read data from a json file"
/** This is editor 4 */
var global_var = 10


"generate a small green cube rotating around a parent of a large red sphere"
const redSphere = new Entity()
redSphere.addComponent(new SphereShape())
redSphere.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(2, 2, 2) }))
redSphere.addComponent(new Material())
redSphere.getComponent(Material).albedoColor = Color3.Red()
engine.addEntity(redSphere)

const greenCube = new Entity()
greenCube.addComponent(new BoxShape())
greenCube.addComponent(new Transform({ position: new Vector3(1, 0, 0), scale: new Vector3(0.5, 0.5, 0.5) }))
greenCube.addComponent(new Material())
greenCube.getComponent(Material).albedoColor = Color3.Green()
greenCube.setParent(redSphere)
engine.addEntity(greenCube)

class RotatingSystem implements ISystem {
  update(dt: number) {
    const rotationSpeed = 45
    greenCube.getComponent(Transform).rotate(Vector3.Up(), rotationSpeed * dt)
  }
}

engine.addSystem(new RotatingSystem())


"generate a small green cube rotating around a large red sphere"
const sphere = new Entity()
sphere.addComponent(new Transform({
  position: new Vector3(0, 2, 0)
}))
sphere.addComponent(new SphereShape())

const cube = new Entity()
cube.addComponent(new Transform({
  position: new Vector3(0, 0, 0)
}))
cube.addComponent(new BoxShape())

let rotation = 0

cube.addComponent(
  new utils.TriggerComponent(
    new utils.TriggerBoxShape(
      new Vector3(1, 1, 1),
      new Vector3(0, 0, 0)
    ),
    0, // layer
    0, // trigger enter
    null, // trigger exit
    (entity: Entity) => {
      rotation += 0.1
      cube.getComponent(Transform).rotation = Quaternion.Euler(0, rotation, 0)
    }
    ) as any
  )
)

engine.addEntity(cube)
engine.addEntity(sphere)

engine.addSystem(new utils.UpdateSystem(() => {
  rotation += 0.1
  cube.getComponent(Transform).rotation = Quaternion.Euler(0, rotation, 0)
}))

engine.addSystem(new utils.MoveSystem(sphere))

engine.addSystem(new utils.MoveSystem(cube))

engine.start()

</script>
</body>
</html>

import { utils } from '@dcl/ecs-scene-utils'
import { Vector3 } from '@dcl/math'

export function createBox(position: Vector3, size: number, color: string) {
  const cube = new Entity()
  cube.addComponent(new Transform({ position }))
  cube.addComponent(new BoxShape())
  cube.addComponent(new Material())
  cube.getComponent(Material).albedoColor = color
  return cube
}

export function createSphere(position: Vector3, size: number, color: string) {
  const sphere = new Entity()
  sphere.addComponent(new Transform({ position }))
  sphere.addComponent(new SphereShape())
  sphere.addComponent(new Material())
  sphere.getComponent(Material).albedoColor = color
  return sphere
}

export function createRotation(rotationSpeed: number) {
  const rotation = new Entity()
  rotation.addComponent(new utils.TriggerComponent(
    new utils.TriggerBoxShape(
      new Vector3(1, 1, 1),
      new Vector3(0, 0, 0)
    ),
    0, // layer
    0, // trigger enter
    null, // trigger exit
    (entity: Entity) => {
      rotation.getComponent(utils).stop = true
    }
    ) as any
  )
  rotation.addComponent(new utils.TriggerComponent(
    new utils.TriggerBoxShape(
      new Vector3(1, 1, 1),
      new Vector3(0, 0, 0)
    ),
    0,


"generate a small green cube rotating around a large red sphere"
const redSphere = new Entity()
redSphere.addComponent(new SphereShape())
redSphere.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: new Vector3(2, 2, 2) }))
const redSphereMaterial = new Material()
redSphereMaterial.albedoColor = Color3.Red()
redSphere.addComponent(redSphereMaterial)
engine.addEntity(redSphere)

const greenCube = new Entity()
greenCube.addComponent(new BoxShape())
greenCube.addComponent(new Transform({ position: new Vector3(5, 1, 7), scale: new Vector3(0.5, 0.5, 0.5) }))
const greenCubeMaterial = new Material()
greenCubeMaterial.albedoColor = Color3.Green()
greenCube.addComponent(greenCubeMaterial)
engine.addEntity(greenCube)

class RotateAroundSphere implements ISystem {
  update(dt: number) {
    const rotationSpeed = 1
    const radius = 2
    const angle = (rotationSpeed * dt) % 360
    const cubePosition = greenCube.getComponent(Transform).position.clone()

    cubePosition.x = redSphere.getComponent(Transform).position.x + Math.sin(angle) * radius
    cubePosition.z = redSphere.getComponent(Transform).position.z + Math.cos(angle) * radius

    greenCube.getComponent(Transform).position = cubePosition
  }
}

engine.addSystem(new RotateAroundSphere())


"generate a small green square rotating around a large red sphere in the middle"
const redSphere = new Entity()
redSphere.addComponent(new SphereShape())
redSphere.addComponent(new Transform({ position: new Vector3(8, 1, 8), scale: new Vector3(2, 2, 2) }))
const redMaterial = new Material()
redMaterial.albedoColor = Color3.Red()
redSphere.addComponent(redMaterial)
engine.addEntity(redSphere)

const greenSquare = new Entity()
greenSquare.addComponent(new PlaneShape())
greenSquare.addComponent(new Transform({ position: new Vector3(8, 1, 6), scale: new Vector3(0.5, 0.5, 0.5) }))
const greenMaterial = new Material()
greenMaterial.albedoColor = Color3.Green()
greenSquare.addComponent(greenMaterial)
engine.addEntity(greenSquare)

class RotatorSystem implements ISystem {
  update(dt: number) {
    const rotationSpeed = 1
    const rotationAxis = Vector3.Up()
    const rotation = Quaternion.Euler(0, rotationSpeed * dt, 0)
    greenSquare.getComponent(Transform).rotateAround(redSphere.getComponent(Transform).position, rotationAxis, rotationSpeed * dt)
  }
}

engine.addSystem(new RotatorSystem())


"generate a cube"
const cube = new Entity()
cube.addComponent(new BoxShape())
cube.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
cube.addComponent(new Material())
cube.getComponent(Material).albedoColor = Color3.Random()
engine.addEntity(cube)
-- This code creates a cube at position (5, 1, 5) with a random color in Decentraland 


"Generate a cube"
const cubeEntity = new Entity()
cubeEntity.addComponent(new BoxShape())
cubeEntity.addComponent(new Transform({ position: new Vector3(5, 1, 5), scale: Vector3.One() }))
engine.addEntity(cubeEntity)
-- A simple cube has been generated in Decentraland at position (5, 1, 5) 

