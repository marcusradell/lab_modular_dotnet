
public class IdentitiesKit
{
    public IdentitiesKit()
    {

    }

    private string Url(string relativeUrl) => $"/identities{relativeUrl}";

    public void MapRouter(WebApplication app)
    {
        app.MapGet(Url("/get_all"), () => new[] { "user1", "user2" })
            .WithName("GetAllIdentities")
            .WithOpenApi();
    }
}