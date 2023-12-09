public class IdentitiesKit
{
    public void MapGroup(RouteGroupBuilder group)
    {
        group.MapGet("/get_all", () => new[] { "user1", "user2" })
            .WithName("GetAllIdentities")
            .WithOpenApi();
    }
}