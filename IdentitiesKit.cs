public class IdentitiesKit
{
    public Identity[] GetAll()
    {
        return new Identity[2] { new("marcus@radell.net"), new("moa@radell.net") };
    }

    public void MapGroup(RouteGroupBuilder group)
    {
        group.MapGet("/get_all", GetAll)
            .WithName("GetAllIdentities")
            .WithOpenApi();
    }
}

public record Identity(string email);