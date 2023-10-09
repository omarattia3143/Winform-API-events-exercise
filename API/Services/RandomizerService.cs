namespace API.Services;

public class RandomizerService : IRandomizerService
{
    public int Randomize() => new Random().Next(1, 11);
}