public class Neuron
{
  public float[] Weights;
  public float Bias;
  public float Output;

  public Neuron(int numberOfInputs)
  {
    Weights = new float[numberOfInputs];
    Bias = 0f;
    Output = 0f;

    for (int i = 0; i < numberOfInputs; i++)
    {
      // Initialize weights with random values
      Weights[i] = UnityEngine.Random.Range(-1f, 1f);
    }
    // Initialize bias with random value
    Bias = UnityEngine.Random.Range(-1f, 1f);
  }
}
