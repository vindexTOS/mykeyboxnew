namespace MyKeyBox.Shared.Infrastructure;

public class Transformation
{
    public async Task<TDto> AsDto<TEntity,TDto> (TEntity entity) where TDto:new()
    {
        if (entity is null)
            throw new InvalidCastException();

        Dictionary<string, object?> transformWarehouse=new();
        var eType=entity.GetType();
        var tEntityProp=eType.GetProperties();
        
        for (short i = 0; i < tEntityProp.Length; i++)
            transformWarehouse.Add(tEntityProp[i].Name,tEntityProp[i].GetValue(entity));

        var tDto = new TDto();
        var dType=tDto.GetType();
        var tDtoProp=dType.GetProperties();

        for (short i = 0; i < tDtoProp.Length; i++)
        {
            transformWarehouse.TryGetValue(tDtoProp[i].Name, out object? value);
            tDtoProp[i].SetValue(tDto,value);
        }
        
        return tDto;
    }
    /*public static TEntity AsEntity(TDto entity)
    {
        
    }

    private static U AsToAs<T, U>(T type)
    {
        
    }*/
}