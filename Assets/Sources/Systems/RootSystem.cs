public sealed class RootSystem : Feature {
  public RootSystem(Contexts contexts) {
    Add(new CreatePlayerSystem(contexts));
    Add(new LogHealthSystem(contexts));
  }
}