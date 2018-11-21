using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.Audio.Fields;
using XBMCRPC.AudioLibrary;
using XBMCRPC.Library.Fields;
using XBMCRPC.List;
using XBMCRPC.List.Filter;

namespace XBMCRPC.Methods
{
   public class AudioLibrary
   {
        private readonly Client _client;
          public AudioLibrary(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Cleans the audio library from non-existent items
                /// </summary>
        public async Task<string> Clean()
        {
            var jArgs = new JObject();
            return await _client.GetData<string>("AudioLibrary.Clean", jArgs);
        }

                /// <summary>
                /// Exports all items from the audio library
                /// </summary>
        public async Task<string> Export(Export_optionsPath options)
        {
            var jArgs = new JObject();
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("AudioLibrary.Export", jArgs);
        }

                /// <summary>
                /// Exports all items from the audio library
                /// </summary>
        public async Task<string> Export(Export_options1 options)
        {
            var jArgs = new JObject();
             if (options != null)
             {
                 var jpropoptions = JToken.FromObject(options, _client.Serializer);
                 jArgs.Add(new JProperty("options", jpropoptions));
             }
            return await _client.GetData<string>("AudioLibrary.Export", jArgs);
        }

                /// <summary>
                /// Exports all items from the audio library
                /// </summary>
        public async Task<string> Export()
        {
            var jArgs = new JObject();
            return await _client.GetData<string>("AudioLibrary.Export", jArgs);
        }

                /// <summary>
                /// Retrieve details about a specific album
                /// </summary>
        public async Task<GetAlbumDetailsResponse> GetAlbumDetails(int albumid=0, Album properties=null)
        {
            var jArgs = new JObject();
             if (albumid != null)
             {
                 var jpropalbumid = JToken.FromObject(albumid, _client.Serializer);
                 jArgs.Add(new JProperty("albumid", jpropalbumid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetAlbumDetailsResponse>("AudioLibrary.GetAlbumDetails", jArgs);
        }

                /// <summary>
                /// Retrieve all albums from specified artist or genre
                /// </summary>
        public async Task<GetAlbumsResponse> GetAlbums(GetAlbums_filterGenreid filter, Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetAlbumsResponse>("AudioLibrary.GetAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve all albums from specified artist or genre
                /// </summary>
        public async Task<GetAlbumsResponse> GetAlbums(GetAlbums_filterGenre filter, Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetAlbumsResponse>("AudioLibrary.GetAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve all albums from specified artist or genre
                /// </summary>
        public async Task<GetAlbumsResponse> GetAlbums(GetAlbums_filterArtistid filter, Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetAlbumsResponse>("AudioLibrary.GetAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve all albums from specified artist or genre
                /// </summary>
        public async Task<GetAlbumsResponse> GetAlbums(GetAlbums_filterArtist filter, Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetAlbumsResponse>("AudioLibrary.GetAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve all albums from specified artist or genre
                /// </summary>
        public async Task<GetAlbumsResponse> GetAlbums(AlbumsAnd filter, Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetAlbumsResponse>("AudioLibrary.GetAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve all albums from specified artist or genre
                /// </summary>
        public async Task<GetAlbumsResponse> GetAlbums(AlbumsOr filter, Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetAlbumsResponse>("AudioLibrary.GetAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve all albums from specified artist or genre
                /// </summary>
        public async Task<GetAlbumsResponse> GetAlbums(Rule.Albums filter, Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetAlbumsResponse>("AudioLibrary.GetAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve all albums from specified artist or genre
                /// </summary>
        public async Task<GetAlbumsResponse> GetAlbums(Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
            return await _client.GetData<GetAlbumsResponse>("AudioLibrary.GetAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve details about a specific artist
                /// </summary>
        public async Task<GetArtistDetailsResponse> GetArtistDetails(int artistid=0, Artist properties=null)
        {
            var jArgs = new JObject();
             if (artistid != null)
             {
                 var jpropartistid = JToken.FromObject(artistid, _client.Serializer);
                 jArgs.Add(new JProperty("artistid", jpropartistid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetArtistDetailsResponse>("AudioLibrary.GetArtistDetails", jArgs);
        }

                /// <summary>
                /// Retrieve all artists
                /// </summary>
        public async Task<GetArtistsResponse> GetArtists(GetArtists_filterGenreid filter, bool? albumartistsonly=null, Artist properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumartistsonly != null)
             {
                 var jpropalbumartistsonly = JToken.FromObject(albumartistsonly, _client.Serializer);
                 jArgs.Add(new JProperty("albumartistsonly", jpropalbumartistsonly));
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetArtistsResponse>("AudioLibrary.GetArtists", jArgs);
        }

                /// <summary>
                /// Retrieve all artists
                /// </summary>
        public async Task<GetArtistsResponse> GetArtists(GetArtists_filterGenre filter, bool? albumartistsonly=null, Artist properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumartistsonly != null)
             {
                 var jpropalbumartistsonly = JToken.FromObject(albumartistsonly, _client.Serializer);
                 jArgs.Add(new JProperty("albumartistsonly", jpropalbumartistsonly));
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetArtistsResponse>("AudioLibrary.GetArtists", jArgs);
        }

                /// <summary>
                /// Retrieve all artists
                /// </summary>
        public async Task<GetArtistsResponse> GetArtists(GetArtists_filterAlbumid filter, bool? albumartistsonly=null, Artist properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumartistsonly != null)
             {
                 var jpropalbumartistsonly = JToken.FromObject(albumartistsonly, _client.Serializer);
                 jArgs.Add(new JProperty("albumartistsonly", jpropalbumartistsonly));
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetArtistsResponse>("AudioLibrary.GetArtists", jArgs);
        }

                /// <summary>
                /// Retrieve all artists
                /// </summary>
        public async Task<GetArtistsResponse> GetArtists(GetArtists_filterAlbum filter, bool? albumartistsonly=null, Artist properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumartistsonly != null)
             {
                 var jpropalbumartistsonly = JToken.FromObject(albumartistsonly, _client.Serializer);
                 jArgs.Add(new JProperty("albumartistsonly", jpropalbumartistsonly));
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetArtistsResponse>("AudioLibrary.GetArtists", jArgs);
        }

                /// <summary>
                /// Retrieve all artists
                /// </summary>
        public async Task<GetArtistsResponse> GetArtists(GetArtists_filterSongid filter, bool? albumartistsonly=null, Artist properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumartistsonly != null)
             {
                 var jpropalbumartistsonly = JToken.FromObject(albumartistsonly, _client.Serializer);
                 jArgs.Add(new JProperty("albumartistsonly", jpropalbumartistsonly));
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetArtistsResponse>("AudioLibrary.GetArtists", jArgs);
        }

                /// <summary>
                /// Retrieve all artists
                /// </summary>
        public async Task<GetArtistsResponse> GetArtists(ArtistsAnd filter, bool? albumartistsonly=null, Artist properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumartistsonly != null)
             {
                 var jpropalbumartistsonly = JToken.FromObject(albumartistsonly, _client.Serializer);
                 jArgs.Add(new JProperty("albumartistsonly", jpropalbumartistsonly));
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetArtistsResponse>("AudioLibrary.GetArtists", jArgs);
        }

                /// <summary>
                /// Retrieve all artists
                /// </summary>
        public async Task<GetArtistsResponse> GetArtists(ArtistsOr filter, bool? albumartistsonly=null, Artist properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumartistsonly != null)
             {
                 var jpropalbumartistsonly = JToken.FromObject(albumartistsonly, _client.Serializer);
                 jArgs.Add(new JProperty("albumartistsonly", jpropalbumartistsonly));
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetArtistsResponse>("AudioLibrary.GetArtists", jArgs);
        }

                /// <summary>
                /// Retrieve all artists
                /// </summary>
        public async Task<GetArtistsResponse> GetArtists(Rule.Artists filter, bool? albumartistsonly=null, Artist properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumartistsonly != null)
             {
                 var jpropalbumartistsonly = JToken.FromObject(albumartistsonly, _client.Serializer);
                 jArgs.Add(new JProperty("albumartistsonly", jpropalbumartistsonly));
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetArtistsResponse>("AudioLibrary.GetArtists", jArgs);
        }

                /// <summary>
                /// Retrieve all artists
                /// </summary>
        public async Task<GetArtistsResponse> GetArtists(bool? albumartistsonly=null, Artist properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumartistsonly != null)
             {
                 var jpropalbumartistsonly = JToken.FromObject(albumartistsonly, _client.Serializer);
                 jArgs.Add(new JProperty("albumartistsonly", jpropalbumartistsonly));
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
            return await _client.GetData<GetArtistsResponse>("AudioLibrary.GetArtists", jArgs);
        }

                /// <summary>
                /// Retrieve all genres
                /// </summary>
        public async Task<GetGenresResponse> GetGenres(Genre properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
            return await _client.GetData<GetGenresResponse>("AudioLibrary.GetGenres", jArgs);
        }

                /// <summary>
                /// Retrieve recently added albums
                /// </summary>
        public async Task<GetRecentlyAddedAlbumsResponse> GetRecentlyAddedAlbums(Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
            return await _client.GetData<GetRecentlyAddedAlbumsResponse>("AudioLibrary.GetRecentlyAddedAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve recently added songs
                /// </summary>
        public async Task<GetRecentlyAddedSongsResponse> GetRecentlyAddedSongs(int albumlimit=0, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
             if (albumlimit != null)
             {
                 var jpropalbumlimit = JToken.FromObject(albumlimit, _client.Serializer);
                 jArgs.Add(new JProperty("albumlimit", jpropalbumlimit));
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
            return await _client.GetData<GetRecentlyAddedSongsResponse>("AudioLibrary.GetRecentlyAddedSongs", jArgs);
        }

                /// <summary>
                /// Retrieve recently played albums
                /// </summary>
        public async Task<GetRecentlyPlayedAlbumsResponse> GetRecentlyPlayedAlbums(Album properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
            return await _client.GetData<GetRecentlyPlayedAlbumsResponse>("AudioLibrary.GetRecentlyPlayedAlbums", jArgs);
        }

                /// <summary>
                /// Retrieve recently played songs
                /// </summary>
        public async Task<GetRecentlyPlayedSongsResponse> GetRecentlyPlayedSongs(Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
            return await _client.GetData<GetRecentlyPlayedSongsResponse>("AudioLibrary.GetRecentlyPlayedSongs", jArgs);
        }

                /// <summary>
                /// Retrieve details about a specific song
                /// </summary>
        public async Task<GetSongDetailsResponse> GetSongDetails(int songid=0, Song properties=null)
        {
            var jArgs = new JObject();
             if (songid != null)
             {
                 var jpropsongid = JToken.FromObject(songid, _client.Serializer);
                 jArgs.Add(new JProperty("songid", jpropsongid));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<GetSongDetailsResponse>("AudioLibrary.GetSongDetails", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(GetSongs_filterGenreid filter, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(GetSongs_filterGenre filter, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(GetSongs_filterArtistid filter, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(GetSongs_filterArtist filter, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(GetSongs_filterAlbumid filter, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(GetSongs_filterAlbum filter, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(SongsAnd filter, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(SongsOr filter, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(Rule.Songs filter, Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Retrieve all songs from specified album, artist or genre
                /// </summary>
        public async Task<GetSongsResponse> GetSongs(Song properties=null, Limits limits=null, Sort sort=null)
        {
            var jArgs = new JObject();
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
            return await _client.GetData<GetSongsResponse>("AudioLibrary.GetSongs", jArgs);
        }

                /// <summary>
                /// Scans the audio sources for new library items
                /// </summary>
        public async Task<string> Scan(string directory=null)
        {
            var jArgs = new JObject();
             if (directory != null)
             {
                 var jpropdirectory = JToken.FromObject(directory, _client.Serializer);
                 jArgs.Add(new JProperty("directory", jpropdirectory));
             }
            return await _client.GetData<string>("AudioLibrary.Scan", jArgs);
        }

                /// <summary>
                /// Update the given album with the given details
                /// </summary>
        public async Task<string> SetAlbumDetails(int albumid=0, string title=null, List<string> artist=null, string description=null, List<string> genre=null, List<string> theme=null, List<string> mood=null, List<string> style=null, string type=null, string albumlabel=null, int? rating=null, int? year=null)
        {
            var jArgs = new JObject();
             if (albumid != null)
             {
                 var jpropalbumid = JToken.FromObject(albumid, _client.Serializer);
                 jArgs.Add(new JProperty("albumid", jpropalbumid));
             }
             if (title != null)
             {
                 var jproptitle = JToken.FromObject(title, _client.Serializer);
                 jArgs.Add(new JProperty("title", jproptitle));
             }
             if (artist != null)
             {
                 var jpropartist = JToken.FromObject(artist, _client.Serializer);
                 jArgs.Add(new JProperty("artist", jpropartist));
             }
             if (description != null)
             {
                 var jpropdescription = JToken.FromObject(description, _client.Serializer);
                 jArgs.Add(new JProperty("description", jpropdescription));
             }
             if (genre != null)
             {
                 var jpropgenre = JToken.FromObject(genre, _client.Serializer);
                 jArgs.Add(new JProperty("genre", jpropgenre));
             }
             if (theme != null)
             {
                 var jproptheme = JToken.FromObject(theme, _client.Serializer);
                 jArgs.Add(new JProperty("theme", jproptheme));
             }
             if (mood != null)
             {
                 var jpropmood = JToken.FromObject(mood, _client.Serializer);
                 jArgs.Add(new JProperty("mood", jpropmood));
             }
             if (style != null)
             {
                 var jpropstyle = JToken.FromObject(style, _client.Serializer);
                 jArgs.Add(new JProperty("style", jpropstyle));
             }
             if (type != null)
             {
                 var jproptype = JToken.FromObject(type, _client.Serializer);
                 jArgs.Add(new JProperty("type", jproptype));
             }
             if (albumlabel != null)
             {
                 var jpropalbumlabel = JToken.FromObject(albumlabel, _client.Serializer);
                 jArgs.Add(new JProperty("albumlabel", jpropalbumlabel));
             }
             if (rating != null)
             {
                 var jproprating = JToken.FromObject(rating, _client.Serializer);
                 jArgs.Add(new JProperty("rating", jproprating));
             }
             if (year != null)
             {
                 var jpropyear = JToken.FromObject(year, _client.Serializer);
                 jArgs.Add(new JProperty("year", jpropyear));
             }
            return await _client.GetData<string>("AudioLibrary.SetAlbumDetails", jArgs);
        }

                /// <summary>
                /// Update the given artist with the given details
                /// </summary>
        public async Task<string> SetArtistDetails(int artistid=0, string artist=null, List<string> instrument=null, List<string> style=null, List<string> mood=null, string born=null, string formed=null, string description=null, List<string> genre=null, string died=null, string disbanded=null, List<string> yearsactive=null)
        {
            var jArgs = new JObject();
             if (artistid != null)
             {
                 var jpropartistid = JToken.FromObject(artistid, _client.Serializer);
                 jArgs.Add(new JProperty("artistid", jpropartistid));
             }
             if (artist != null)
             {
                 var jpropartist = JToken.FromObject(artist, _client.Serializer);
                 jArgs.Add(new JProperty("artist", jpropartist));
             }
             if (instrument != null)
             {
                 var jpropinstrument = JToken.FromObject(instrument, _client.Serializer);
                 jArgs.Add(new JProperty("instrument", jpropinstrument));
             }
             if (style != null)
             {
                 var jpropstyle = JToken.FromObject(style, _client.Serializer);
                 jArgs.Add(new JProperty("style", jpropstyle));
             }
             if (mood != null)
             {
                 var jpropmood = JToken.FromObject(mood, _client.Serializer);
                 jArgs.Add(new JProperty("mood", jpropmood));
             }
             if (born != null)
             {
                 var jpropborn = JToken.FromObject(born, _client.Serializer);
                 jArgs.Add(new JProperty("born", jpropborn));
             }
             if (formed != null)
             {
                 var jpropformed = JToken.FromObject(formed, _client.Serializer);
                 jArgs.Add(new JProperty("formed", jpropformed));
             }
             if (description != null)
             {
                 var jpropdescription = JToken.FromObject(description, _client.Serializer);
                 jArgs.Add(new JProperty("description", jpropdescription));
             }
             if (genre != null)
             {
                 var jpropgenre = JToken.FromObject(genre, _client.Serializer);
                 jArgs.Add(new JProperty("genre", jpropgenre));
             }
             if (died != null)
             {
                 var jpropdied = JToken.FromObject(died, _client.Serializer);
                 jArgs.Add(new JProperty("died", jpropdied));
             }
             if (disbanded != null)
             {
                 var jpropdisbanded = JToken.FromObject(disbanded, _client.Serializer);
                 jArgs.Add(new JProperty("disbanded", jpropdisbanded));
             }
             if (yearsactive != null)
             {
                 var jpropyearsactive = JToken.FromObject(yearsactive, _client.Serializer);
                 jArgs.Add(new JProperty("yearsactive", jpropyearsactive));
             }
            return await _client.GetData<string>("AudioLibrary.SetArtistDetails", jArgs);
        }

                /// <summary>
                /// Update the given song with the given details
                /// </summary>
        public async Task<string> SetSongDetails(int songid=0, string title=null, List<string> artist=null, List<string> albumartist=null, List<string> genre=null, int? year=null, int? rating=null, string album=null, int? track=null, int? disc=null, int? duration=null, string comment=null, string musicbrainztrackid=null, string musicbrainzartistid=null, string musicbrainzalbumid=null, string musicbrainzalbumartistid=null)
        {
            var jArgs = new JObject();
             if (songid != null)
             {
                 var jpropsongid = JToken.FromObject(songid, _client.Serializer);
                 jArgs.Add(new JProperty("songid", jpropsongid));
             }
             if (title != null)
             {
                 var jproptitle = JToken.FromObject(title, _client.Serializer);
                 jArgs.Add(new JProperty("title", jproptitle));
             }
             if (artist != null)
             {
                 var jpropartist = JToken.FromObject(artist, _client.Serializer);
                 jArgs.Add(new JProperty("artist", jpropartist));
             }
             if (albumartist != null)
             {
                 var jpropalbumartist = JToken.FromObject(albumartist, _client.Serializer);
                 jArgs.Add(new JProperty("albumartist", jpropalbumartist));
             }
             if (genre != null)
             {
                 var jpropgenre = JToken.FromObject(genre, _client.Serializer);
                 jArgs.Add(new JProperty("genre", jpropgenre));
             }
             if (year != null)
             {
                 var jpropyear = JToken.FromObject(year, _client.Serializer);
                 jArgs.Add(new JProperty("year", jpropyear));
             }
             if (rating != null)
             {
                 var jproprating = JToken.FromObject(rating, _client.Serializer);
                 jArgs.Add(new JProperty("rating", jproprating));
             }
             if (album != null)
             {
                 var jpropalbum = JToken.FromObject(album, _client.Serializer);
                 jArgs.Add(new JProperty("album", jpropalbum));
             }
             if (track != null)
             {
                 var jproptrack = JToken.FromObject(track, _client.Serializer);
                 jArgs.Add(new JProperty("track", jproptrack));
             }
             if (disc != null)
             {
                 var jpropdisc = JToken.FromObject(disc, _client.Serializer);
                 jArgs.Add(new JProperty("disc", jpropdisc));
             }
             if (duration != null)
             {
                 var jpropduration = JToken.FromObject(duration, _client.Serializer);
                 jArgs.Add(new JProperty("duration", jpropduration));
             }
             if (comment != null)
             {
                 var jpropcomment = JToken.FromObject(comment, _client.Serializer);
                 jArgs.Add(new JProperty("comment", jpropcomment));
             }
             if (musicbrainztrackid != null)
             {
                 var jpropmusicbrainztrackid = JToken.FromObject(musicbrainztrackid, _client.Serializer);
                 jArgs.Add(new JProperty("musicbrainztrackid", jpropmusicbrainztrackid));
             }
             if (musicbrainzartistid != null)
             {
                 var jpropmusicbrainzartistid = JToken.FromObject(musicbrainzartistid, _client.Serializer);
                 jArgs.Add(new JProperty("musicbrainzartistid", jpropmusicbrainzartistid));
             }
             if (musicbrainzalbumid != null)
             {
                 var jpropmusicbrainzalbumid = JToken.FromObject(musicbrainzalbumid, _client.Serializer);
                 jArgs.Add(new JProperty("musicbrainzalbumid", jpropmusicbrainzalbumid));
             }
             if (musicbrainzalbumartistid != null)
             {
                 var jpropmusicbrainzalbumartistid = JToken.FromObject(musicbrainzalbumartistid, _client.Serializer);
                 jArgs.Add(new JProperty("musicbrainzalbumartistid", jpropmusicbrainzalbumartistid));
             }
            return await _client.GetData<string>("AudioLibrary.SetSongDetails", jArgs);
        }

        public delegate void OnCleanFinishedDelegate(string sender=null, object data=null);
        public event OnCleanFinishedDelegate OnCleanFinished;
        internal void RaiseOnCleanFinished(string sender=null, object data=null)
        {
            if (OnCleanFinished != null)
            {
                OnCleanFinished.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnCleanStartedDelegate(string sender=null, object data=null);
        public event OnCleanStartedDelegate OnCleanStarted;
        internal void RaiseOnCleanStarted(string sender=null, object data=null)
        {
            if (OnCleanStarted != null)
            {
                OnCleanStarted.BeginInvoke(sender, data, null, null);
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

        public delegate void OnScanFinishedDelegate(string sender=null, object data=null);
        public event OnScanFinishedDelegate OnScanFinished;
        internal void RaiseOnScanFinished(string sender=null, object data=null)
        {
            if (OnScanFinished != null)
            {
                OnScanFinished.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnScanStartedDelegate(string sender=null, object data=null);
        public event OnScanStartedDelegate OnScanStarted;
        internal void RaiseOnScanStarted(string sender=null, object data=null)
        {
            if (OnScanStarted != null)
            {
                OnScanStarted.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnUpdateDelegate(string sender=null, OnUpdate_data data=null);
        public event OnUpdateDelegate OnUpdate;
        internal void RaiseOnUpdate(string sender=null, OnUpdate_data data=null)
        {
            if (OnUpdate != null)
            {
                OnUpdate.BeginInvoke(sender, data, null, null);
            }
        }
   }
}
