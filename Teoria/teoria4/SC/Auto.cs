namespace Teoria4;
class Auto {
    private string? _marca;
    private int _modelo;
    public Auto (string marca, int modelo)
    {_marca = marca;
    _modelo = modelo;}
    public string GetDescripcion()=> $"Auto {_marca} {_modelo}"}
}
