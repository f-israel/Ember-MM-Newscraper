using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.Global;
using XBMCRPC.List.Fields;
using XBMCRPC.Player;
using XBMCRPC.Player.Notifications;
using XBMCRPC.Player.Property;
using XBMCRPC.Playlist;
using GetProperties_properties = XBMCRPC.Player.GetProperties_properties;
using Time = XBMCRPC.Player.Position.Time;

namespace XBMCRPC.Methods
{
   public class Player
   {
        private readonly Client _client;
          public Player(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Returns all active players
                /// </summary>
        public async Task<List<GetActivePlayersResponseItem>> GetActivePlayers()
        {
            var jArgs = new JObject();
            return await _client.GetData<List<GetActivePlayersResponseItem>>("Player.GetActivePlayers", jArgs);
        }

                /// <summary>
                /// Retrieves the currently played item
                /// </summary>
        public async Task<GetItemResponse> GetItem(int playerid=0, All properties=null)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetItemResponse>("Player.GetItem", jArgs);
        }

                /// <summary>
                /// Retrieves the values of the given properties
                /// </summary>
        public async Task<Value> GetProperties(int playerid=0, GetProperties_properties properties=null)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<Value>("Player.GetProperties", jArgs);
        }

                /// <summary>
                /// Go to previous/next/specific item in the playlist
                /// </summary>
        public async Task<string> GoTo(GoTo_to1 to, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (to != null)
             {
                 var jpropto = JToken.FromObject(to, _client.Serializer);
                 jArgs.Add(new JProperty("to", jpropto));
             }
            return await _client.GetData<string>("Player.GoTo", jArgs);
        }

                /// <summary>
                /// Go to previous/next/specific item in the playlist
                /// </summary>
        public async Task<string> GoTo(int to, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (to != null)
             {
                 var jpropto = JToken.FromObject(to, _client.Serializer);
                 jArgs.Add(new JProperty("to", jpropto));
             }
            return await _client.GetData<string>("Player.GoTo", jArgs);
        }

                /// <summary>
                /// Go to previous/next/specific item in the playlist
                /// </summary>
        public async Task<string> GoTo(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<string>("Player.GoTo", jArgs);
        }

                /// <summary>
                /// If picture is zoomed move viewport left/right/up/down otherwise skip previous/next
                /// </summary>
        public async Task<string> Move(int playerid=0, Move_direction direction=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (direction != null)
             {
                 var jpropdirection = JToken.FromObject(direction, _client.Serializer);
                 jArgs.Add(new JProperty("direction", jpropdirection));
             }
            return await _client.GetData<string>("Player.Move", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(Open_item1 item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(ItemFile item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(Item1 item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(ItemMovieid item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(ItemEpisodeid item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(ItemMusicvideoid item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(ItemArtistid item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(ItemAlbumid item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(ItemSongid item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(ItemGenreid item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(Open_item2 item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(Open_itemPartymode item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(Open_itemChannelid item, Open_options options=null)
        {
            var jArgs = new JObject();
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Start playback of either the playlist with the given ID, a slideshow with the pictures from the given directory or a single file or an item from the database.
                /// </summary>
        public async Task<string> Open(Open_options options=null)
        {
            var jArgs = new JObject();
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("Player.Open", jArgs);
        }

                /// <summary>
                /// Pauses or unpause playback and returns the new state
                /// </summary>
        public async Task<Speed> PlayPause(bool play, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (play != null)
             {
                 var jpropplay = JToken.FromObject(play, _client.Serializer);
                 jArgs.Add(new JProperty("play", jpropplay));
             }
            return await _client.GetData<Speed>("Player.PlayPause", jArgs);
        }

                /// <summary>
                /// Pauses or unpause playback and returns the new state
                /// </summary>
        public async Task<Speed> PlayPause(Toggle2 play, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (play != null)
             {
                 var jpropplay = JToken.FromObject(play, _client.Serializer);
                 jArgs.Add(new JProperty("play", jpropplay));
             }
            return await _client.GetData<Speed>("Player.PlayPause", jArgs);
        }

                /// <summary>
                /// Pauses or unpause playback and returns the new state
                /// </summary>
        public async Task<Speed> PlayPause(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<Speed>("Player.PlayPause", jArgs);
        }

                /// <summary>
                /// Rotates current picture
                /// </summary>
        public async Task<string> Rotate(int playerid=0, Rotate_value value=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (value != null)
             {
                 var jpropvalue = JToken.FromObject(value, _client.Serializer);
                 jArgs.Add(new JProperty("value", jpropvalue));
             }
            return await _client.GetData<string>("Player.Rotate", jArgs);
        }

                /// <summary>
                /// Seek through the playing item
                /// </summary>
        public async Task<SeekResponse> Seek(double value, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (value != null)
             {
                 var jpropvalue = JToken.FromObject(value, _client.Serializer);
                 jArgs.Add(new JProperty("value", jpropvalue));
             }
            return await _client.GetData<SeekResponse>("Player.Seek", jArgs);
        }

                /// <summary>
                /// Seek through the playing item
                /// </summary>
        public async Task<SeekResponse> Seek(Time value, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (value != null)
             {
                 var jpropvalue = JToken.FromObject(value, _client.Serializer);
                 jArgs.Add(new JProperty("value", jpropvalue));
             }
            return await _client.GetData<SeekResponse>("Player.Seek", jArgs);
        }

                /// <summary>
                /// Seek through the playing item
                /// </summary>
        public async Task<SeekResponse> Seek(Seek_value1 value, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (value != null)
             {
                 var jpropvalue = JToken.FromObject(value, _client.Serializer);
                 jArgs.Add(new JProperty("value", jpropvalue));
             }
            return await _client.GetData<SeekResponse>("Player.Seek", jArgs);
        }

                /// <summary>
                /// Seek through the playing item
                /// </summary>
        public async Task<SeekResponse> Seek(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<SeekResponse>("Player.Seek", jArgs);
        }

                /// <summary>
                /// Set the audio stream played by the player
                /// </summary>
        public async Task<string> SetAudioStream(SetAudioStream_stream1 stream, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (stream != null)
             {
                 var jpropstream = JToken.FromObject(stream, _client.Serializer);
                 jArgs.Add(new JProperty("stream", jpropstream));
             }
            return await _client.GetData<string>("Player.SetAudioStream", jArgs);
        }

                /// <summary>
                /// Set the audio stream played by the player
                /// </summary>
        public async Task<string> SetAudioStream(int stream, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (stream != null)
             {
                 var jpropstream = JToken.FromObject(stream, _client.Serializer);
                 jArgs.Add(new JProperty("stream", jpropstream));
             }
            return await _client.GetData<string>("Player.SetAudioStream", jArgs);
        }

                /// <summary>
                /// Set the audio stream played by the player
                /// </summary>
        public async Task<string> SetAudioStream(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<string>("Player.SetAudioStream", jArgs);
        }

                /// <summary>
                /// Turn partymode on or off
                /// </summary>
        public async Task<string> SetPartymode(bool partymode, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (partymode != null)
             {
                 var jproppartymode = JToken.FromObject(partymode, _client.Serializer);
                 jArgs.Add(new JProperty("partymode", jproppartymode));
             }
            return await _client.GetData<string>("Player.SetPartymode", jArgs);
        }

                /// <summary>
                /// Turn partymode on or off
                /// </summary>
        public async Task<string> SetPartymode(Toggle2 partymode, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (partymode != null)
             {
                 var jproppartymode = JToken.FromObject(partymode, _client.Serializer);
                 jArgs.Add(new JProperty("partymode", jproppartymode));
             }
            return await _client.GetData<string>("Player.SetPartymode", jArgs);
        }

                /// <summary>
                /// Turn partymode on or off
                /// </summary>
        public async Task<string> SetPartymode(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<string>("Player.SetPartymode", jArgs);
        }

                /// <summary>
                /// Set the repeat mode of the player
                /// </summary>
        public async Task<string> SetRepeat(Repeat repeat, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (repeat != null)
             {
                 var jproprepeat = JToken.FromObject(repeat, _client.Serializer);
                 jArgs.Add(new JProperty("repeat", jproprepeat));
             }
            return await _client.GetData<string>("Player.SetRepeat", jArgs);
        }

                /// <summary>
                /// Set the repeat mode of the player
                /// </summary>
        public async Task<string> SetRepeat(SetRepeat_repeat1 repeat, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (repeat != null)
             {
                 var jproprepeat = JToken.FromObject(repeat, _client.Serializer);
                 jArgs.Add(new JProperty("repeat", jproprepeat));
             }
            return await _client.GetData<string>("Player.SetRepeat", jArgs);
        }

                /// <summary>
                /// Set the repeat mode of the player
                /// </summary>
        public async Task<string> SetRepeat(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<string>("Player.SetRepeat", jArgs);
        }

                /// <summary>
                /// Shuffle/Unshuffle items in the player
                /// </summary>
        public async Task<string> SetShuffle(bool shuffle, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (shuffle != null)
             {
                 var jpropshuffle = JToken.FromObject(shuffle, _client.Serializer);
                 jArgs.Add(new JProperty("shuffle", jpropshuffle));
             }
            return await _client.GetData<string>("Player.SetShuffle", jArgs);
        }

                /// <summary>
                /// Shuffle/Unshuffle items in the player
                /// </summary>
        public async Task<string> SetShuffle(Toggle2 shuffle, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (shuffle != null)
             {
                 var jpropshuffle = JToken.FromObject(shuffle, _client.Serializer);
                 jArgs.Add(new JProperty("shuffle", jpropshuffle));
             }
            return await _client.GetData<string>("Player.SetShuffle", jArgs);
        }

                /// <summary>
                /// Shuffle/Unshuffle items in the player
                /// </summary>
        public async Task<string> SetShuffle(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<string>("Player.SetShuffle", jArgs);
        }

                /// <summary>
                /// Set the speed of the current playback
                /// </summary>
        public async Task<Speed> SetSpeed(int speed, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (speed != null)
             {
                 var jpropspeed = JToken.FromObject(speed, _client.Serializer);
                 jArgs.Add(new JProperty("speed", jpropspeed));
             }
            return await _client.GetData<Speed>("Player.SetSpeed", jArgs);
        }

                /// <summary>
                /// Set the speed of the current playback
                /// </summary>
        public async Task<Speed> SetSpeed(IncrementDecrement speed, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (speed != null)
             {
                 var jpropspeed = JToken.FromObject(speed, _client.Serializer);
                 jArgs.Add(new JProperty("speed", jpropspeed));
             }
            return await _client.GetData<Speed>("Player.SetSpeed", jArgs);
        }

                /// <summary>
                /// Set the speed of the current playback
                /// </summary>
        public async Task<Speed> SetSpeed(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<Speed>("Player.SetSpeed", jArgs);
        }

                /// <summary>
                /// Set the subtitle displayed by the player
                /// </summary>
        public async Task<string> SetSubtitle(SetSubtitle_subtitle1 subtitle, int playerid=0, bool enable=false)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (subtitle != null)
             {
                 var jpropsubtitle = JToken.FromObject(subtitle, _client.Serializer);
                 jArgs.Add(new JProperty("subtitle", jpropsubtitle));
             }
             if (enable != null)
             {
                 var jpropenable = JToken.FromObject(enable, _client.Serializer);
                 jArgs.Add(new JProperty("enable", jpropenable));
             }
            return await _client.GetData<string>("Player.SetSubtitle", jArgs);
        }

                /// <summary>
                /// Set the subtitle displayed by the player
                /// </summary>
        public async Task<string> SetSubtitle(int subtitle, int playerid=0, bool enable=false)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (subtitle != null)
             {
                 var jpropsubtitle = JToken.FromObject(subtitle, _client.Serializer);
                 jArgs.Add(new JProperty("subtitle", jpropsubtitle));
             }
             if (enable != null)
             {
                 var jpropenable = JToken.FromObject(enable, _client.Serializer);
                 jArgs.Add(new JProperty("enable", jpropenable));
             }
            return await _client.GetData<string>("Player.SetSubtitle", jArgs);
        }

                /// <summary>
                /// Set the subtitle displayed by the player
                /// </summary>
        public async Task<string> SetSubtitle(int playerid=0, bool enable=false)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (enable != null)
             {
                 var jpropenable = JToken.FromObject(enable, _client.Serializer);
                 jArgs.Add(new JProperty("enable", jpropenable));
             }
            return await _client.GetData<string>("Player.SetSubtitle", jArgs);
        }

                /// <summary>
                /// Stops playback
                /// </summary>
        public async Task<string> Stop(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<string>("Player.Stop", jArgs);
        }

                /// <summary>
                /// Zoom current picture
                /// </summary>
        public async Task<string> Zoom(Zoom_zoom1 zoom, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (zoom != null)
             {
                 var jpropzoom = JToken.FromObject(zoom, _client.Serializer);
                 jArgs.Add(new JProperty("zoom", jpropzoom));
             }
            return await _client.GetData<string>("Player.Zoom", jArgs);
        }

                /// <summary>
                /// Zoom current picture
                /// </summary>
        public async Task<string> Zoom(int zoom, int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
             if (zoom != null)
             {
                 var jpropzoom = JToken.FromObject(zoom, _client.Serializer);
                 jArgs.Add(new JProperty("zoom", jpropzoom));
             }
            return await _client.GetData<string>("Player.Zoom", jArgs);
        }

                /// <summary>
                /// Zoom current picture
                /// </summary>
        public async Task<string> Zoom(int playerid=0)
        {
            var jArgs = new JObject();
             if (playerid != null)
             {
                 var jpropplayerid = JToken.FromObject(playerid, _client.Serializer);
                 jArgs.Add(new JProperty("playerid", jpropplayerid));
             }
            return await _client.GetData<string>("Player.Zoom", jArgs);
        }

        public delegate void OnPauseDelegate(string sender=null, Data data=null);
        public event OnPauseDelegate OnPause;
        internal void RaiseOnPause(string sender=null, Data data=null)
        {
            if (OnPause != null)
            {
                OnPause.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnPlayDelegate(string sender=null, Data data=null);
        public event OnPlayDelegate OnPlay;
        internal void RaiseOnPlay(string sender=null, Data data=null)
        {
            if (OnPlay != null)
            {
                OnPlay.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnPropertyChangedDelegate(string sender=null, OnPropertyChanged_data data=null);
        public event OnPropertyChangedDelegate OnPropertyChanged;
        internal void RaiseOnPropertyChanged(string sender=null, OnPropertyChanged_data data=null)
        {
            if (OnPropertyChanged != null)
            {
                OnPropertyChanged.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnSeekDelegate(string sender=null, OnSeek_data data=null);
        public event OnSeekDelegate OnSeek;
        internal void RaiseOnSeek(string sender=null, OnSeek_data data=null)
        {
            if (OnSeek != null)
            {
                OnSeek.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnSpeedChangedDelegate(string sender=null, Data data=null);
        public event OnSpeedChangedDelegate OnSpeedChanged;
        internal void RaiseOnSpeedChanged(string sender=null, Data data=null)
        {
            if (OnSpeedChanged != null)
            {
                OnSpeedChanged.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnStopDelegate(string sender=null, OnStop_data data=null);
        public event OnStopDelegate OnStop;
        internal void RaiseOnStop(string sender=null, OnStop_data data=null)
        {
            if (OnStop != null)
            {
                OnStop.BeginInvoke(sender, data, null, null);
            }
        }
   }
}
