using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.List;
using XBMCRPC.List.Fields;
using XBMCRPC.Playlist;
using XBMCRPC.Playlist.Property;

namespace XBMCRPC.Methods
{
   public class Playlist
   {
        private readonly Client _client;
          public Playlist(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(ItemFile item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(Item1 item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(ItemMovieid item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(ItemEpisodeid item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(ItemMusicvideoid item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(ItemArtistid item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(ItemAlbumid item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(ItemSongid item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(ItemGenreid item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(List<object> item, int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Add item(s) to playlist
                /// </summary>
        public async Task<string> Add(int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
            return await _client.GetData<string>("Playlist.Add", jArgs);
        }

                /// <summary>
                /// Clear playlist
                /// </summary>
        public async Task<string> Clear(int playlistid=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
            return await _client.GetData<string>("Playlist.Clear", jArgs);
        }

                /// <summary>
                /// Get all items from playlist
                /// </summary>
        public async Task<GetItemsResponse> GetItems(int playlistid=0, All properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
             if (sort != null)
             {
                 var jpropsort = JToken.FromObject(sort, _client.Serializer);
                 jArgs.Add(new JProperty("sort", jpropsort));
             }
            return await _client.GetData<GetItemsResponse>("Playlist.GetItems", jArgs);
        }

                /// <summary>
                /// Returns all existing playlists
                /// </summary>
        public async Task<List<GetPlaylistsResponseItem>> GetPlaylists()
        {
            var jArgs = new JObject();
            return await _client.GetData<List<GetPlaylistsResponseItem>>("Playlist.GetPlaylists", jArgs);
        }

                /// <summary>
                /// Retrieves the values of the given properties
                /// </summary>
        public async Task<Value> GetProperties(int playlistid=0, GetProperties_properties properties=null)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<Value>("Playlist.GetProperties", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(ItemFile item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(Item1 item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(ItemMovieid item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(ItemEpisodeid item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(ItemMusicvideoid item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(ItemArtistid item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(ItemAlbumid item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(ItemSongid item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(ItemGenreid item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(List<object> item, int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
             if (item != null)
             {
                 var jpropitem = JToken.FromObject(item, _client.Serializer);
                 jArgs.Add(new JProperty("item", jpropitem));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Insert item(s) into playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Insert(int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
            return await _client.GetData<string>("Playlist.Insert", jArgs);
        }

                /// <summary>
                /// Remove item from playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Remove(int playlistid=0, int position=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position != null)
             {
                 var jpropposition = JToken.FromObject(position, _client.Serializer);
                 jArgs.Add(new JProperty("position", jpropposition));
             }
            return await _client.GetData<string>("Playlist.Remove", jArgs);
        }

                /// <summary>
                /// Swap items in the playlist. Does not work for picture playlists (aka slideshows).
                /// </summary>
        public async Task<string> Swap(int playlistid=0, int position1=0, int position2=0)
        {
            var jArgs = new JObject();
             if (playlistid != null)
             {
                 var jpropplaylistid = JToken.FromObject(playlistid, _client.Serializer);
                 jArgs.Add(new JProperty("playlistid", jpropplaylistid));
             }
             if (position1 != null)
             {
                 var jpropposition1 = JToken.FromObject(position1, _client.Serializer);
                 jArgs.Add(new JProperty("position1", jpropposition1));
             }
             if (position2 != null)
             {
                 var jpropposition2 = JToken.FromObject(position2, _client.Serializer);
                 jArgs.Add(new JProperty("position2", jpropposition2));
             }
            return await _client.GetData<string>("Playlist.Swap", jArgs);
        }

        public delegate void OnAddDelegate(string sender=null, OnAdd_data data=null);
        public event OnAddDelegate OnAdd;
        internal void RaiseOnAdd(string sender=null, OnAdd_data data=null)
        {
            if (OnAdd != null)
            {
                OnAdd.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnClearDelegate(string sender=null, OnClear_data data=null);
        public event OnClearDelegate OnClear;
        internal void RaiseOnClear(string sender=null, OnClear_data data=null)
        {
            if (OnClear != null)
            {
                OnClear.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnRemoveDelegate(string sender=null, OnRemove_data data=null);
        public event OnRemoveDelegate OnRemove;
        internal void RaiseOnRemove(string sender=null, OnRemove_data data=null)
        {
            if (OnRemove != null)
            {
                OnRemove.BeginInvoke(sender, data, null, null);
            }
        }
   }
}
