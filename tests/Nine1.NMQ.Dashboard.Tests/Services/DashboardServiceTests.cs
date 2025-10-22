using Nine1.NMQ.Dashboard.Core.Interfaces;
using Nine1.NMQ.Dashboard.Infrastructure.Services;

namespace Nine1.NMQ.Dashboard.Tests.Services;

public class DashboardServiceTests
{
    [Fact]
    public async Task GetStatusAsync_ShouldReturnValidStatus()
    {
        // Arrange
        IDashboardService service = new DashboardService();

        // Act
        var status = await service.GetStatusAsync();

        // Assert
        Assert.NotNull(status);
        Assert.NotEmpty(status);
        Assert.Equal("Dashboard is running", status);
    }
}
