using Discord;
using Discord.Commands;


namespace DiscordBot.Modules;

public class Commands : ModuleBase<SocketCommandContext>
{
    [Command("commands")]
    public async Task Commandi()
    {
        await ReplyAsync("!commands: Show available commands" +
                         "\n.\n!create log: Create a news channel with the log of the bot" +
                         "\n.\n!time: Show date and time");
        
    }

    [Command("time")]
    public async Task Time()
    {
        await ReplyAsync("Date: " + DateTime.Now.ToString("dd/MM/yyyy") + "\nTime: " + DateTime.Now.ToString("HH:mm:ss"));
        
    }


}