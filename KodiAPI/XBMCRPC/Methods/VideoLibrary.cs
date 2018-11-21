using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using XBMCRPC.Library.Fields;
using XBMCRPC.List;
using XBMCRPC.List.Filter;
using XBMCRPC.Media;
using XBMCRPC.Video;
using XBMCRPC.Video.Fields;
using XBMCRPC.VideoLibrary;

namespace XBMCRPC.Methods
{
    public class VideoLibrary
    {
        private readonly Client _client;
        public VideoLibrary(Client client)
        {
            _client = client;
        }

        /// <summary>
        /// Cleans the video library from non-existent items
        /// </summary>
        public async Task<string> Clean()
        {
            JObject jArgs = new JObject();
            return await _client.GetData<string>("VideoLibrary.Clean", jArgs);
        }

        /// <summary>
        /// Exports all items from the video library
        /// </summary>
        public async Task<string> Export(Export_optionsPath options)
        {
            JObject jArgs = new JObject();
            if (options != null)
            {
                JToken jpropoptions = JToken.FromObject(options, _client.Serializer);
                jArgs.Add(new JProperty("options", jpropoptions));
            }
            return await _client.GetData<string>("VideoLibrary.Export", jArgs);
        }

        /// <summary>
        /// Exports all items from the video library
        /// </summary>
        public async Task<string> Export(Export_options1 options)
        {
            JObject jArgs = new JObject();
            if (options != null)
            {
                JToken jpropoptions = JToken.FromObject(options, _client.Serializer);
                jArgs.Add(new JProperty("options", jpropoptions));
            }
            return await _client.GetData<string>("VideoLibrary.Export", jArgs);
        }

        /// <summary>
        /// Exports all items from the video library
        /// </summary>
        public async Task<string> Export()
        {
            JObject jArgs = new JObject();
            return await _client.GetData<string>("VideoLibrary.Export", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific tv show episode
        /// </summary>
        public async Task<GetEpisodeDetailsResponse> GetEpisodeDetails(int episodeid = 0, Episode properties = null)
        {
            JObject jArgs = new JObject();
            if (episodeid != null)
            {
                JToken jpropepisodeid = JToken.FromObject(episodeid, _client.Serializer);
                jArgs.Add(new JProperty("episodeid", jpropepisodeid));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<GetEpisodeDetailsResponse>("VideoLibrary.GetEpisodeDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<GetEpisodesResponse> GetEpisodes(GetEpisodes_filterGenreid filter, int tvshowid = 0, int season = 0, Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<GetEpisodesResponse> GetEpisodes(GetEpisodes_filterGenre filter, int tvshowid = 0, int season = 0, Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<GetEpisodesResponse> GetEpisodes(GetEpisodes_filterYear filter, int tvshowid = 0, int season = 0, Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<GetEpisodesResponse> GetEpisodes(GetEpisodes_filterActor filter, int tvshowid = 0, int season = 0, Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<GetEpisodesResponse> GetEpisodes(GetEpisodes_filterDirector filter, int tvshowid = 0, int season = 0, Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<GetEpisodesResponse> GetEpisodes(EpisodesAnd filter, int tvshowid = 0, int season = 0, Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<GetEpisodesResponse> GetEpisodes(EpisodesOr filter, int tvshowid = 0, int season = 0, Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<GetEpisodesResponse> GetEpisodes(Rule.Episodes filter, int tvshowid = 0, int season = 0, Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all tv show episodes
        /// </summary>
        public async Task<GetEpisodesResponse> GetEpisodes(int tvshowid = 0, int season = 0, Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetEpisodesResponse>("VideoLibrary.GetEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all genres
        /// </summary>
        public async Task<GetGenresResponse> GetGenres(GetGenres_type type = 0, Genre properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (type != null)
            {
                JToken jproptype = JToken.FromObject(type, _client.Serializer);
                jArgs.Add(new JProperty("type", jproptype));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetGenresResponse>("VideoLibrary.GetGenres", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific movie
        /// </summary>
        public async Task<GetMovieDetailsResponse> GetMovieDetails(int movieid = 0, Movie properties = null)
        {
            JObject jArgs = new JObject();
            if (movieid != null)
            {
                JToken jpropmovieid = JToken.FromObject(movieid, _client.Serializer);
                jArgs.Add(new JProperty("movieid", jpropmovieid));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<GetMovieDetailsResponse>("VideoLibrary.GetMovieDetails", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific movie set
        /// </summary>
        public async Task<GetMovieSetDetailsResponse> GetMovieSetDetails(int setid = 0, MovieSet properties = null, GetMovieSetDetails_movies movies = null)
        {
            JObject jArgs = new JObject();
            if (setid != null)
            {
                JToken jpropsetid = JToken.FromObject(setid, _client.Serializer);
                jArgs.Add(new JProperty("setid", jpropsetid));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (movies != null)
            {
                JToken jpropmovies = JToken.FromObject(movies, _client.Serializer);
                jArgs.Add(new JProperty("movies", jpropmovies));
            }
            return await _client.GetData<GetMovieSetDetailsResponse>("VideoLibrary.GetMovieSetDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all movie sets
        /// </summary>
        public async Task<GetMovieSetsResponse> GetMovieSets(MovieSet properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetMovieSetsResponse>("VideoLibrary.GetMovieSets", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterGenreid filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterGenre filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterYear filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterActor filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterDirector filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterStudio filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterCountry filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterSetid filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterSet filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(GetMovies_filterTag filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(MoviesAnd filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(MoviesOr filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(Rule.Movies filter, Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all movies
        /// </summary>
        public async Task<GetMoviesResponse> GetMovies(Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetMoviesResponse>("VideoLibrary.GetMovies", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific music video
        /// </summary>
        public async Task<GetMusicVideoDetailsResponse> GetMusicVideoDetails(int musicvideoid = 0, MusicVideo properties = null)
        {
            JObject jArgs = new JObject();
            if (musicvideoid != null)
            {
                JToken jpropmusicvideoid = JToken.FromObject(musicvideoid, _client.Serializer);
                jArgs.Add(new JProperty("musicvideoid", jpropmusicvideoid));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<GetMusicVideoDetailsResponse>("VideoLibrary.GetMusicVideoDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(GetMusicVideos_filterArtist filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(GetMusicVideos_filterGenreid filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(GetMusicVideos_filterGenre filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(GetMusicVideos_filterYear filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(GetMusicVideos_filterDirector filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(GetMusicVideos_filterStudio filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(GetMusicVideos_filterTag filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(MusicVideosAnd filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(MusicVideosOr filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(Rule.MusicVideos filter, MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all music videos
        /// </summary>
        public async Task<GetMusicVideosResponse> GetMusicVideos(MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetMusicVideosResponse>("VideoLibrary.GetMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve all recently added tv episodes
        /// </summary>
        public async Task<GetRecentlyAddedEpisodesResponse> GetRecentlyAddedEpisodes(Episode properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetRecentlyAddedEpisodesResponse>("VideoLibrary.GetRecentlyAddedEpisodes", jArgs);
        }

        /// <summary>
        /// Retrieve all recently added movies
        /// </summary>
        public async Task<GetRecentlyAddedMoviesResponse> GetRecentlyAddedMovies(Movie properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetRecentlyAddedMoviesResponse>("VideoLibrary.GetRecentlyAddedMovies", jArgs);
        }

        /// <summary>
        /// Retrieve all recently added music videos
        /// </summary>
        public async Task<GetRecentlyAddedMusicVideosResponse> GetRecentlyAddedMusicVideos(MusicVideo properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetRecentlyAddedMusicVideosResponse>("VideoLibrary.GetRecentlyAddedMusicVideos", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific tv show season
        /// </summary>
        public async Task<GetSeasonDetailsResponse> GetSeasonDetails(int seasonid = 0, Season properties = null)
        {
            JObject jArgs = new JObject();
            if (seasonid != null)
            {
                JToken jpropseasonid = JToken.FromObject(seasonid, _client.Serializer);
                jArgs.Add(new JProperty("seasonid", jpropseasonid));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<GetSeasonDetailsResponse>("VideoLibrary.GetSeasonDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all tv seasons
        /// </summary>
        public async Task<GetSeasonsResponse> GetSeasons(int tvshowid = 0, Season properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetSeasonsResponse>("VideoLibrary.GetSeasons", jArgs);
        }

        /// <summary>
        /// Retrieve details about a specific tv show
        /// </summary>
        public async Task<GetTVShowDetailsResponse> GetTVShowDetails(int tvshowid = 0, TVShow properties = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            return await _client.GetData<GetTVShowDetailsResponse>("VideoLibrary.GetTVShowDetails", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(GetTVShows_filterGenreid filter, TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(GetTVShows_filterGenre filter, TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(GetTVShows_filterYear filter, TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(GetTVShows_filterActor filter, TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(GetTVShows_filterStudio filter, TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(GetTVShows_filterTag filter, TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(TVShowsAnd filter, TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(TVShowsOr filter, TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(Rule.TVShows filter, TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            if (filter != null)
            {
                JToken jpropfilter = JToken.FromObject(filter, _client.Serializer);
                jArgs.Add(new JProperty("filter", jpropfilter));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Retrieve all tv shows
        /// </summary>
        public async Task<GetTVShowsResponse> GetTVShows(TVShow properties = null, Limits limits = null, Sort sort = null)
        {
            JObject jArgs = new JObject();
            if (properties != null)
            {
                JToken jpropproperties = JToken.FromObject(properties, _client.Serializer);
                jArgs.Add(new JProperty("properties", jpropproperties));
            }
            if (limits != null)
            {
                JToken jproplimits = JToken.FromObject(limits, _client.Serializer);
                jArgs.Add(new JProperty("limits", jproplimits));
            }
            if (sort != null)
            {
                JToken jpropsort = JToken.FromObject(sort, _client.Serializer);
                jArgs.Add(new JProperty("sort", jpropsort));
            }
            return await _client.GetData<GetTVShowsResponse>("VideoLibrary.GetTVShows", jArgs);
        }

        /// <summary>
        /// Removes the given episode from the library
        /// </summary>
        public async Task<string> RemoveEpisode(int episodeid = 0)
        {
            JObject jArgs = new JObject();
            if (episodeid != null)
            {
                JToken jpropepisodeid = JToken.FromObject(episodeid, _client.Serializer);
                jArgs.Add(new JProperty("episodeid", jpropepisodeid));
            }
            return await _client.GetData<string>("VideoLibrary.RemoveEpisode", jArgs);
        }

        /// <summary>
        /// Removes the given movie from the library
        /// </summary>
        public async Task<string> RemoveMovie(int movieid = 0)
        {
            JObject jArgs = new JObject();
            
                JToken jpropmovieid = JToken.FromObject(movieid, _client.Serializer);
                jArgs.Add(new JProperty("movieid", jpropmovieid));
            
            return await _client.GetData<string>("VideoLibrary.RemoveMovie", jArgs);
        }

        /// <summary>
        /// Removes the given music video from the library
        /// </summary>
        public async Task<string> RemoveMusicVideo(int musicvideoid = 0)
        {
            JObject jArgs = new JObject();
            if (musicvideoid != null)
            {
                JToken jpropmusicvideoid = JToken.FromObject(musicvideoid, _client.Serializer);
                jArgs.Add(new JProperty("musicvideoid", jpropmusicvideoid));
            }
            return await _client.GetData<string>("VideoLibrary.RemoveMusicVideo", jArgs);
        }

        /// <summary>
        /// Removes the given tv show from the library
        /// </summary>
        public async Task<string> RemoveTVShow(int tvshowid = 0)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            return await _client.GetData<string>("VideoLibrary.RemoveTVShow", jArgs);
        }

        /// <summary>
        /// Scans the video sources for new library items
        /// </summary>
        public async Task<string> Scan(string directory = null)
        {
            JObject jArgs = new JObject();
            if (directory != null)
            {
                JToken jpropdirectory = JToken.FromObject(directory, _client.Serializer);
                jArgs.Add(new JProperty("directory", jpropdirectory));
            }
            return await _client.GetData<string>("VideoLibrary.Scan", jArgs);
        }

        /// <summary>
        /// Update the given episode with the given details
        /// </summary>
        public async Task<string> SetEpisodeDetails(
            int episodeid = 0,
            string title = null,
            int? playcount = null,
            int? runtime = null,
            List<string> director = null,
            string plot = null,
            double? rating = null,
            string votes = null,
            string lastplayed = null,
            List<string> writer = null,
            string firstaired = null,
            string productioncode = null,
            int? season = null,
            int? episode = null,
            string originaltitle = null,
            string thumbnail = null,
            string fanart = null,
            Artwork.Set art = null,
            Resume resume = null)
        {
            JObject jArgs = new JObject();
            if (episodeid != null)
            {
                JToken jpropepisodeid = JToken.FromObject(episodeid, _client.Serializer);
                jArgs.Add(new JProperty("episodeid", jpropepisodeid));
            }
            if (title != null)
            {
                JToken jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                JToken jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (runtime != null)
            {
                JToken jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                jArgs.Add(new JProperty("runtime", jpropruntime));
            }
            if (director != null)
            {
                JToken jpropdirector = JToken.FromObject(director, _client.Serializer);
                jArgs.Add(new JProperty("director", jpropdirector));
            }
            if (plot != null)
            {
                JToken jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (rating != null)
            {
                JToken jproprating = JToken.FromObject(rating, _client.Serializer);
                jArgs.Add(new JProperty("rating", jproprating));
            }
            if (votes != null)
            {
                JToken jpropvotes = JToken.FromObject(votes, _client.Serializer);
                jArgs.Add(new JProperty("votes", jpropvotes));
            }
            if (lastplayed != null)
            {
                JToken jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (writer != null)
            {
                JToken jpropwriter = JToken.FromObject(writer, _client.Serializer);
                jArgs.Add(new JProperty("writer", jpropwriter));
            }
            if (firstaired != null)
            {
                JToken jpropfirstaired = JToken.FromObject(firstaired, _client.Serializer);
                jArgs.Add(new JProperty("firstaired", jpropfirstaired));
            }
            if (productioncode != null)
            {
                JToken jpropproductioncode = JToken.FromObject(productioncode, _client.Serializer);
                jArgs.Add(new JProperty("productioncode", jpropproductioncode));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (episode != null)
            {
                JToken jpropepisode = JToken.FromObject(episode, _client.Serializer);
                jArgs.Add(new JProperty("episode", jpropepisode));
            }
            if (originaltitle != null)
            {
                JToken jproporiginaltitle = JToken.FromObject(originaltitle, _client.Serializer);
                jArgs.Add(new JProperty("originaltitle", jproporiginaltitle));
            }
            if (thumbnail != null)
            {
                JToken jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                JToken jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (art != null)
            {
                JToken jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (resume != null)
            {
                JToken jpropresume = JToken.FromObject(resume, _client.Serializer);
                jArgs.Add(new JProperty("resume", jpropresume));
            }
            return await _client.GetData<string>("VideoLibrary.SetEpisodeDetails", jArgs);
        }

        /// <summary>
        /// Update the given episode with the given details
        /// </summary>
        public async Task<string> SetEpisodeDetailsNew(
            int episodeid = 0,
            string title = null,
            int? playcount = null,
            int? runtime = null,
            List<string> director = null,
            string plot = null,
            double? rating = null,
            string votes = null,
            string lastplayed = null,
            List<string> writer = null,
            string firstaired = null,
            string productioncode = null,
            int? season = null,
            int? episode = null,
            string originaltitle = null,
            string thumbnail = null,
            string fanart = null,
            Artwork.Set art = null,
            Resume resume = null,
            int? userrating = null,
            string dateadded = null,
            UniqueID.Set uniqueid = null)
        {
            JObject jArgs = new JObject();
            if (episodeid != null)
            {
                JToken jpropepisodeid = JToken.FromObject(episodeid, _client.Serializer);
                jArgs.Add(new JProperty("episodeid", jpropepisodeid));
            }
            if (title != null)
            {
                JToken jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                JToken jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (runtime != null)
            {
                JToken jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                jArgs.Add(new JProperty("runtime", jpropruntime));
            }
            if (director != null)
            {
                JToken jpropdirector = JToken.FromObject(director, _client.Serializer);
                jArgs.Add(new JProperty("director", jpropdirector));
            }
            if (plot != null)
            {
                JToken jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (rating != null)
            {
                JToken jproprating = JToken.FromObject(rating, _client.Serializer);
                jArgs.Add(new JProperty("rating", jproprating));
            }
            if (votes != null)
            {
                JToken jpropvotes = JToken.FromObject(votes, _client.Serializer);
                jArgs.Add(new JProperty("votes", jpropvotes));
            }
            if (lastplayed != null)
            {
                JToken jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (writer != null)
            {
                JToken jpropwriter = JToken.FromObject(writer, _client.Serializer);
                jArgs.Add(new JProperty("writer", jpropwriter));
            }
            if (firstaired != null)
            {
                JToken jpropfirstaired = JToken.FromObject(firstaired, _client.Serializer);
                jArgs.Add(new JProperty("firstaired", jpropfirstaired));
            }
            if (productioncode != null)
            {
                JToken jpropproductioncode = JToken.FromObject(productioncode, _client.Serializer);
                jArgs.Add(new JProperty("productioncode", jpropproductioncode));
            }
            if (season != null)
            {
                JToken jpropseason = JToken.FromObject(season, _client.Serializer);
                jArgs.Add(new JProperty("season", jpropseason));
            }
            if (episode != null)
            {
                JToken jpropepisode = JToken.FromObject(episode, _client.Serializer);
                jArgs.Add(new JProperty("episode", jpropepisode));
            }
            if (originaltitle != null)
            {
                JToken jproporiginaltitle = JToken.FromObject(originaltitle, _client.Serializer);
                jArgs.Add(new JProperty("originaltitle", jproporiginaltitle));
            }
            if (thumbnail != null)
            {
                JToken jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                JToken jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (art != null)
            {
                JToken jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (resume != null)
            {
                JToken jpropresume = JToken.FromObject(resume, _client.Serializer);
                jArgs.Add(new JProperty("resume", jpropresume));
            }
            if (userrating != null)
            {
                JToken jpropuserrating = JToken.FromObject(userrating, _client.Serializer);
                jArgs.Add(new JProperty("userrating", jpropuserrating));
            }
            if (dateadded != null)
            {
                JToken jpropdateadded = JToken.FromObject(dateadded, _client.Serializer);
                jArgs.Add(new JProperty("dateadded", jpropdateadded));
            }
            if (uniqueid != null)
            {
                JToken jpropuniqueid = JToken.FromObject(uniqueid, _client.Serializer);
                jArgs.Add(new JProperty("uniqueid", jpropuniqueid));
            }
            return await _client.GetData<string>("VideoLibrary.SetEpisodeDetails", jArgs);
        }

        /// <summary>
        /// Update the given movie with the given details
        /// </summary>
        public async Task<string> SetMovieDetails(
            int movieid = 0,
            string title = null,
            int? playcount = null,
            int? runtime = null,
            List<string> director = null,
            List<string> studio = null,
            int? year = null,
            string plot = null,
            List<string> genre = null,
            double? rating = null,
            string mpaa = null,
            string imdbnumber = null,
            string votes = null,
            string lastplayed = null,
            string originaltitle = null,
            string trailer = null,
            string tagline = null,
            string plotoutline = null,
            List<string> writer = null,
            List<string> country = null,
            int? top250 = null,
            string sorttitle = null,
            string set = null,
            List<string> showlink = null,
            string thumbnail = null,
            string fanart = null,
            List<string> tag = null,
            Artwork.Set art = null,
            Resume resume = null)
        {
            JObject jArgs = new JObject();
            if (movieid != null)
            {
                JToken jpropmovieid = JToken.FromObject(movieid, _client.Serializer);
                jArgs.Add(new JProperty("movieid", jpropmovieid));
            }
            if (title != null)
            {
                JToken jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                JToken jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (runtime != null)
            {
                JToken jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                jArgs.Add(new JProperty("runtime", jpropruntime));
            }
            if (director != null)
            {
                JToken jpropdirector = JToken.FromObject(director, _client.Serializer);
                jArgs.Add(new JProperty("director", jpropdirector));
            }
            if (studio != null)
            {
                JToken jpropstudio = JToken.FromObject(studio, _client.Serializer);
                jArgs.Add(new JProperty("studio", jpropstudio));
            }
            if (year != null)
            {
                JToken jpropyear = JToken.FromObject(year, _client.Serializer);
                jArgs.Add(new JProperty("year", jpropyear));
            }
            if (plot != null)
            {
                JToken jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (genre != null)
            {
                JToken jpropgenre = JToken.FromObject(genre, _client.Serializer);
                jArgs.Add(new JProperty("genre", jpropgenre));
            }
            if (rating != null)
            {
                JToken jproprating = JToken.FromObject(rating, _client.Serializer);
                jArgs.Add(new JProperty("rating", jproprating));
            }
            if (mpaa != null)
            {
                JToken jpropmpaa = JToken.FromObject(mpaa, _client.Serializer);
                jArgs.Add(new JProperty("mpaa", jpropmpaa));
            }
            if (imdbnumber != null)
            {
                JToken jpropimdbnumber = JToken.FromObject(imdbnumber, _client.Serializer);
                jArgs.Add(new JProperty("imdbnumber", jpropimdbnumber));
            }
            if (votes != null)
            {
                JToken jpropvotes = JToken.FromObject(votes, _client.Serializer);
                jArgs.Add(new JProperty("votes", jpropvotes));
            }
            if (lastplayed != null)
            {
                JToken jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (originaltitle != null)
            {
                JToken jproporiginaltitle = JToken.FromObject(originaltitle, _client.Serializer);
                jArgs.Add(new JProperty("originaltitle", jproporiginaltitle));
            }
            if (trailer != null)
            {
                JToken jproptrailer = JToken.FromObject(trailer, _client.Serializer);
                jArgs.Add(new JProperty("trailer", jproptrailer));
            }
            if (tagline != null)
            {
                JToken jproptagline = JToken.FromObject(tagline, _client.Serializer);
                jArgs.Add(new JProperty("tagline", jproptagline));
            }
            if (plotoutline != null)
            {
                JToken jpropplotoutline = JToken.FromObject(plotoutline, _client.Serializer);
                jArgs.Add(new JProperty("plotoutline", jpropplotoutline));
            }
            if (writer != null)
            {
                JToken jpropwriter = JToken.FromObject(writer, _client.Serializer);
                jArgs.Add(new JProperty("writer", jpropwriter));
            }
            if (country != null)
            {
                JToken jpropcountry = JToken.FromObject(country, _client.Serializer);
                jArgs.Add(new JProperty("country", jpropcountry));
            }
            if (top250 != null)
            {
                JToken jproptop250 = JToken.FromObject(top250, _client.Serializer);
                jArgs.Add(new JProperty("top250", jproptop250));
            }
            if (sorttitle != null)
            {
                JToken jpropsorttitle = JToken.FromObject(sorttitle, _client.Serializer);
                jArgs.Add(new JProperty("sorttitle", jpropsorttitle));
            }
            if (set != null)
            {
                JToken jpropset = JToken.FromObject(set, _client.Serializer);
                jArgs.Add(new JProperty("set", jpropset));
            }
            if (showlink != null)
            {
                JToken jpropshowlink = JToken.FromObject(showlink, _client.Serializer);
                jArgs.Add(new JProperty("showlink", jpropshowlink));
            }
            if (thumbnail != null)
            {
                JToken jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                JToken jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (tag != null)
            {
                JToken jproptag = JToken.FromObject(tag, _client.Serializer);
                jArgs.Add(new JProperty("tag", jproptag));
            }
            if (art != null)
            {
                JToken jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (resume != null)
            {
                JToken jpropresume = JToken.FromObject(resume, _client.Serializer);
                jArgs.Add(new JProperty("resume", jpropresume));
            }
            return await _client.GetData<string>("VideoLibrary.SetMovieDetails", jArgs);
        }

        /// <summary>
        /// Update the given movie with the given details
        /// </summary>
        public async Task<string> SetMovieDetailsNew(
            int movieid = 0,
            string title = null,
            int? playcount = null,
            int? runtime = null,
            List<string> director = null,
            List<string> studio = null,
            int? year = null,
            string plot = null,
            List<string> genre = null,
            double? rating = null,
            string mpaa = null,
            string imdbnumber = null,
            string votes = null,
            string lastplayed = null,
            string originaltitle = null,
            string trailer = null,
            string tagline = null,
            string plotoutline = null,
            List<string> writer = null,
            List<string> country = null,
            int? top250 = null,
            string sorttitle = null,
            string set = null,
            List<string> showlink = null,
            string thumbnail = null,
            string fanart = null,
            List<string> tag = null,
            Artwork.Set art = null,
            Resume resume = null,
            int? userrating = null,
            string dateadded = null,
            string premiered = null,
            UniqueID.Set uniqueid = null)
        {
            JObject jArgs = new JObject();
            if (movieid != null)
            {
                JToken jpropmovieid = JToken.FromObject(movieid, _client.Serializer);
                jArgs.Add(new JProperty("movieid", jpropmovieid));
            }
            if (title != null)
            {
                JToken jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                JToken jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (runtime != null)
            {
                JToken jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                jArgs.Add(new JProperty("runtime", jpropruntime));
            }
            if (director != null)
            {
                JToken jpropdirector = JToken.FromObject(director, _client.Serializer);
                jArgs.Add(new JProperty("director", jpropdirector));
            }
            if (studio != null)
            {
                JToken jpropstudio = JToken.FromObject(studio, _client.Serializer);
                jArgs.Add(new JProperty("studio", jpropstudio));
            }
            if (year != null)
            {
                JToken jpropyear = JToken.FromObject(year, _client.Serializer);
                jArgs.Add(new JProperty("year", jpropyear));
            }
            if (plot != null)
            {
                JToken jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (genre != null)
            {
                JToken jpropgenre = JToken.FromObject(genre, _client.Serializer);
                jArgs.Add(new JProperty("genre", jpropgenre));
            }
            if (rating != null)
            {
                JToken jproprating = JToken.FromObject(rating, _client.Serializer);
                jArgs.Add(new JProperty("rating", jproprating));
            }
            if (mpaa != null)
            {
                JToken jpropmpaa = JToken.FromObject(mpaa, _client.Serializer);
                jArgs.Add(new JProperty("mpaa", jpropmpaa));
            }
            if (imdbnumber != null)
            {
                JToken jpropimdbnumber = JToken.FromObject(imdbnumber, _client.Serializer);
                jArgs.Add(new JProperty("imdbnumber", jpropimdbnumber));
            }
            if (votes != null)
            {
                JToken jpropvotes = JToken.FromObject(votes, _client.Serializer);
                jArgs.Add(new JProperty("votes", jpropvotes));
            }
            if (lastplayed != null)
            {
                JToken jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (originaltitle != null)
            {
                JToken jproporiginaltitle = JToken.FromObject(originaltitle, _client.Serializer);
                jArgs.Add(new JProperty("originaltitle", jproporiginaltitle));
            }
            if (trailer != null)
            {
                JToken jproptrailer = JToken.FromObject(trailer, _client.Serializer);
                jArgs.Add(new JProperty("trailer", jproptrailer));
            }
            if (tagline != null)
            {
                JToken jproptagline = JToken.FromObject(tagline, _client.Serializer);
                jArgs.Add(new JProperty("tagline", jproptagline));
            }
            if (plotoutline != null)
            {
                JToken jpropplotoutline = JToken.FromObject(plotoutline, _client.Serializer);
                jArgs.Add(new JProperty("plotoutline", jpropplotoutline));
            }
            if (writer != null)
            {
                JToken jpropwriter = JToken.FromObject(writer, _client.Serializer);
                jArgs.Add(new JProperty("writer", jpropwriter));
            }
            if (country != null)
            {
                JToken jpropcountry = JToken.FromObject(country, _client.Serializer);
                jArgs.Add(new JProperty("country", jpropcountry));
            }
            if (top250 != null)
            {
                JToken jproptop250 = JToken.FromObject(top250, _client.Serializer);
                jArgs.Add(new JProperty("top250", jproptop250));
            }
            if (sorttitle != null)
            {
                JToken jpropsorttitle = JToken.FromObject(sorttitle, _client.Serializer);
                jArgs.Add(new JProperty("sorttitle", jpropsorttitle));
            }
            if (set != null)
            {
                JToken jpropset = JToken.FromObject(set, _client.Serializer);
                jArgs.Add(new JProperty("set", jpropset));
            }
            if (showlink != null)
            {
                JToken jpropshowlink = JToken.FromObject(showlink, _client.Serializer);
                jArgs.Add(new JProperty("showlink", jpropshowlink));
            }
            if (thumbnail != null)
            {
                JToken jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                JToken jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (tag != null)
            {
                JToken jproptag = JToken.FromObject(tag, _client.Serializer);
                jArgs.Add(new JProperty("tag", jproptag));
            }
            if (art != null)
            {
                JToken jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (resume != null)
            {
                JToken jpropresume = JToken.FromObject(resume, _client.Serializer);
                jArgs.Add(new JProperty("resume", jpropresume));
            }
            if (userrating != null)
            {
                JToken jpropuserrating = JToken.FromObject(userrating, _client.Serializer);
                jArgs.Add(new JProperty("userrating", jpropuserrating));
            }
            if (dateadded != null)
            {
                JToken jpropdateadded = JToken.FromObject(dateadded, _client.Serializer);
                jArgs.Add(new JProperty("dateadded", jpropdateadded));
            }
            if (premiered != null)
            {
                JToken jproppremiered = JToken.FromObject(premiered, _client.Serializer);
                jArgs.Add(new JProperty("premiered", jproppremiered));
            }
            if (uniqueid != null)
            {
                JToken jpropuniqueid = JToken.FromObject(uniqueid, _client.Serializer);
                jArgs.Add(new JProperty("uniqueid", jpropuniqueid));
            }
            return await _client.GetData<string>("VideoLibrary.SetMovieDetails", jArgs);
        }

        /// <summary>
        /// Update the given movie set with the given details
        /// </summary>
        public async Task<string> SetMovieSetDetails(
            int setid = 0,
            string title = null,
            Artwork.Set art = null)
        {
            JObject jArgs = new JObject();
            if (setid != null)
            {
                JToken jpropsetid = JToken.FromObject(setid, _client.Serializer);
                jArgs.Add(new JProperty("setid", jpropsetid));
            }
            if (title != null)
            {
                JToken jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (art != null)
            {
                JToken jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            return await _client.GetData<string>("VideoLibrary.SetMovieSetDetails", jArgs);
        }

        /// <summary>
        /// Update the given music video with the given details
        /// </summary>
        public async Task<string> SetMusicVideoDetails(
            int musicvideoid = 0,
            string title = null,
            int? playcount = null,
            int? runtime = null,
            List<string> director = null,
            List<string> studio = null,
            int? year = null,
            string plot = null,
            string album = null,
            List<string> artist = null,
            List<string> genre = null,
            int? track = null,
            string lastplayed = null,
            string thumbnail = null,
            string fanart = null,
            List<string> tag = null,
            Artwork.Set art = null,
            Resume resume = null)
        {
            JObject jArgs = new JObject();
            if (musicvideoid != null)
            {
                JToken jpropmusicvideoid = JToken.FromObject(musicvideoid, _client.Serializer);
                jArgs.Add(new JProperty("musicvideoid", jpropmusicvideoid));
            }
            if (title != null)
            {
                JToken jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                JToken jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (runtime != null)
            {
                JToken jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                jArgs.Add(new JProperty("runtime", jpropruntime));
            }
            if (director != null)
            {
                JToken jpropdirector = JToken.FromObject(director, _client.Serializer);
                jArgs.Add(new JProperty("director", jpropdirector));
            }
            if (studio != null)
            {
                JToken jpropstudio = JToken.FromObject(studio, _client.Serializer);
                jArgs.Add(new JProperty("studio", jpropstudio));
            }
            if (year != null)
            {
                JToken jpropyear = JToken.FromObject(year, _client.Serializer);
                jArgs.Add(new JProperty("year", jpropyear));
            }
            if (plot != null)
            {
                JToken jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (album != null)
            {
                JToken jpropalbum = JToken.FromObject(album, _client.Serializer);
                jArgs.Add(new JProperty("album", jpropalbum));
            }
            if (artist != null)
            {
                JToken jpropartist = JToken.FromObject(artist, _client.Serializer);
                jArgs.Add(new JProperty("artist", jpropartist));
            }
            if (genre != null)
            {
                JToken jpropgenre = JToken.FromObject(genre, _client.Serializer);
                jArgs.Add(new JProperty("genre", jpropgenre));
            }
            if (track != null)
            {
                JToken jproptrack = JToken.FromObject(track, _client.Serializer);
                jArgs.Add(new JProperty("track", jproptrack));
            }
            if (lastplayed != null)
            {
                JToken jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (thumbnail != null)
            {
                JToken jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                JToken jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (tag != null)
            {
                JToken jproptag = JToken.FromObject(tag, _client.Serializer);
                jArgs.Add(new JProperty("tag", jproptag));
            }
            if (art != null)
            {
                JToken jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (resume != null)
            {
                JToken jpropresume = JToken.FromObject(resume, _client.Serializer);
                jArgs.Add(new JProperty("resume", jpropresume));
            }
            return await _client.GetData<string>("VideoLibrary.SetMusicVideoDetails", jArgs);
        }

        /// <summary>
        /// Update the given season with the given details
        /// </summary>
        public async Task<string> SetSeasonDetails(
            int seasonid = 0,
            Artwork.Set art = null)
        {
            JObject jArgs = new JObject();
            if (seasonid != null)
            {
                JToken jpropseasonid = JToken.FromObject(seasonid, _client.Serializer);
                jArgs.Add(new JProperty("seasonid", jpropseasonid));
            }
            if (art != null)
            {
                JToken jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            return await _client.GetData<string>("VideoLibrary.SetSeasonDetails", jArgs);
        }

        /// <summary>
        /// Update the given tvshow with the given details
        /// </summary>
        public async Task<string> SetTVShowDetails(
            int tvshowid = 0,
            string title = null,
            int? playcount = null,
            List<string> studio = null,
            string plot = null,
            List<string> genre = null,
            double? rating = null,
            string mpaa = null,
            string imdbnumber = null,
            string premiered = null,
            string votes = null,
            string lastplayed = null,
            string originaltitle = null,
            string sorttitle = null,
            string episodeguide = null,
            string thumbnail = null,
            string fanart = null,
            List<string> tag = null,
            Artwork.Set art = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (title != null)
            {
                JToken jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                JToken jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (studio != null)
            {
                JToken jpropstudio = JToken.FromObject(studio, _client.Serializer);
                jArgs.Add(new JProperty("studio", jpropstudio));
            }
            if (plot != null)
            {
                JToken jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (genre != null)
            {
                JToken jpropgenre = JToken.FromObject(genre, _client.Serializer);
                jArgs.Add(new JProperty("genre", jpropgenre));
            }
            if (rating != null)
            {
                JToken jproprating = JToken.FromObject(rating, _client.Serializer);
                jArgs.Add(new JProperty("rating", jproprating));
            }
            if (mpaa != null)
            {
                JToken jpropmpaa = JToken.FromObject(mpaa, _client.Serializer);
                jArgs.Add(new JProperty("mpaa", jpropmpaa));
            }
            if (imdbnumber != null)
            {
                JToken jpropimdbnumber = JToken.FromObject(imdbnumber, _client.Serializer);
                jArgs.Add(new JProperty("imdbnumber", jpropimdbnumber));
            }
            if (premiered != null)
            {
                JToken jproppremiered = JToken.FromObject(premiered, _client.Serializer);
                jArgs.Add(new JProperty("premiered", jproppremiered));
            }
            if (votes != null)
            {
                JToken jpropvotes = JToken.FromObject(votes, _client.Serializer);
                jArgs.Add(new JProperty("votes", jpropvotes));
            }
            if (lastplayed != null)
            {
                JToken jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (originaltitle != null)
            {
                JToken jproporiginaltitle = JToken.FromObject(originaltitle, _client.Serializer);
                jArgs.Add(new JProperty("originaltitle", jproporiginaltitle));
            }
            if (sorttitle != null)
            {
                JToken jpropsorttitle = JToken.FromObject(sorttitle, _client.Serializer);
                jArgs.Add(new JProperty("sorttitle", jpropsorttitle));
            }
            if (episodeguide != null)
            {
                JToken jpropepisodeguide = JToken.FromObject(episodeguide, _client.Serializer);
                jArgs.Add(new JProperty("episodeguide", jpropepisodeguide));
            }
            if (thumbnail != null)
            {
                JToken jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                JToken jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (tag != null)
            {
                JToken jproptag = JToken.FromObject(tag, _client.Serializer);
                jArgs.Add(new JProperty("tag", jproptag));
            }
            if (art != null)
            {
                JToken jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            return await _client.GetData<string>("VideoLibrary.SetTVShowDetails", jArgs);
        }

        /// <summary>
        /// Update the given tvshow with the given details
        /// </summary>
        public async Task<string> SetTVShowDetailsNew(
            int tvshowid = 0,
            string title = null,
            int? playcount = null,
            List<string> studio = null,
            string plot = null,
            List<string> genre = null,
            double? rating = null,
            string mpaa = null,
            string imdbnumber = null,
            string premiered = null,
            string votes = null,
            string lastplayed = null,
            string originaltitle = null,
            string sorttitle = null,
            string episodeguide = null,
            string thumbnail = null,
            string fanart = null,
            List<string> tag = null,
            Artwork.Set art = null,
            int? userrating = null,
            string dateadded = null,
            int? runtime = null,
            string status = null,
            UniqueID.Set uniqueid = null)
        {
            JObject jArgs = new JObject();
            if (tvshowid != null)
            {
                JToken jproptvshowid = JToken.FromObject(tvshowid, _client.Serializer);
                jArgs.Add(new JProperty("tvshowid", jproptvshowid));
            }
            if (title != null)
            {
                JToken jproptitle = JToken.FromObject(title, _client.Serializer);
                jArgs.Add(new JProperty("title", jproptitle));
            }
            if (playcount != null)
            {
                JToken jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                jArgs.Add(new JProperty("playcount", jpropplaycount));
            }
            if (studio != null)
            {
                JToken jpropstudio = JToken.FromObject(studio, _client.Serializer);
                jArgs.Add(new JProperty("studio", jpropstudio));
            }
            if (plot != null)
            {
                JToken jpropplot = JToken.FromObject(plot, _client.Serializer);
                jArgs.Add(new JProperty("plot", jpropplot));
            }
            if (genre != null)
            {
                JToken jpropgenre = JToken.FromObject(genre, _client.Serializer);
                jArgs.Add(new JProperty("genre", jpropgenre));
            }
            if (rating != null)
            {
                JToken jproprating = JToken.FromObject(rating, _client.Serializer);
                jArgs.Add(new JProperty("rating", jproprating));
            }
            if (mpaa != null)
            {
                JToken jpropmpaa = JToken.FromObject(mpaa, _client.Serializer);
                jArgs.Add(new JProperty("mpaa", jpropmpaa));
            }
            if (imdbnumber != null)
            {
                JToken jpropimdbnumber = JToken.FromObject(imdbnumber, _client.Serializer);
                jArgs.Add(new JProperty("imdbnumber", jpropimdbnumber));
            }
            if (premiered != null)
            {
                JToken jproppremiered = JToken.FromObject(premiered, _client.Serializer);
                jArgs.Add(new JProperty("premiered", jproppremiered));
            }
            if (votes != null)
            {
                JToken jpropvotes = JToken.FromObject(votes, _client.Serializer);
                jArgs.Add(new JProperty("votes", jpropvotes));
            }
            if (lastplayed != null)
            {
                JToken jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                jArgs.Add(new JProperty("lastplayed", jproplastplayed));
            }
            if (originaltitle != null)
            {
                JToken jproporiginaltitle = JToken.FromObject(originaltitle, _client.Serializer);
                jArgs.Add(new JProperty("originaltitle", jproporiginaltitle));
            }
            if (sorttitle != null)
            {
                JToken jpropsorttitle = JToken.FromObject(sorttitle, _client.Serializer);
                jArgs.Add(new JProperty("sorttitle", jpropsorttitle));
            }
            if (episodeguide != null)
            {
                JToken jpropepisodeguide = JToken.FromObject(episodeguide, _client.Serializer);
                jArgs.Add(new JProperty("episodeguide", jpropepisodeguide));
            }
            if (thumbnail != null)
            {
                JToken jpropthumbnail = JToken.FromObject(thumbnail, _client.Serializer);
                jArgs.Add(new JProperty("thumbnail", jpropthumbnail));
            }
            if (fanart != null)
            {
                JToken jpropfanart = JToken.FromObject(fanart, _client.Serializer);
                jArgs.Add(new JProperty("fanart", jpropfanart));
            }
            if (tag != null)
            {
                JToken jproptag = JToken.FromObject(tag, _client.Serializer);
                jArgs.Add(new JProperty("tag", jproptag));
            }
            if (art != null)
            {
                JToken jpropart = JToken.FromObject(art, _client.Serializer);
                jArgs.Add(new JProperty("art", jpropart));
            }
            if (userrating != null)
            {
                JToken jpropuserrating = JToken.FromObject(userrating, _client.Serializer);
                jArgs.Add(new JProperty("userrating", jpropuserrating));
            }
            if (dateadded != null)
            {
                JToken jpropdateadded = JToken.FromObject(dateadded, _client.Serializer);
                jArgs.Add(new JProperty("dateadded", jpropdateadded));
            }
            if (runtime != null)
            {
                JToken jpropruntime = JToken.FromObject(runtime, _client.Serializer);
                jArgs.Add(new JProperty("runtime", jpropruntime));
            }
            if (status != null)
            {
                JToken jpropstatus = JToken.FromObject(status, _client.Serializer);
                jArgs.Add(new JProperty("status", jpropstatus));
            }
            if (uniqueid != null)
            {
                JToken jpropuniqueid = JToken.FromObject(uniqueid, _client.Serializer);
                jArgs.Add(new JProperty("uniqueid", jpropuniqueid));
            }
            return await _client.GetData<string>("VideoLibrary.SetTVShowDetails", jArgs);
        }

        public delegate void OnCleanFinishedDelegate(string sender = null, object data = null);
        public event OnCleanFinishedDelegate OnCleanFinished;
        internal void RaiseOnCleanFinished(string sender = null, object data = null)
        {
            if (OnCleanFinished != null)
            {
                OnCleanFinished.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnCleanStartedDelegate(string sender = null, object data = null);
        public event OnCleanStartedDelegate OnCleanStarted;
        internal void RaiseOnCleanStarted(string sender = null, object data = null)
        {
            if (OnCleanStarted != null)
            {
                OnCleanStarted.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnRemoveDelegate(string sender = null, OnRemove_data data = null);
        public event OnRemoveDelegate OnRemove;
        internal void RaiseOnRemove(string sender = null, OnRemove_data data = null)
        {
            if (OnRemove != null)
            {
                OnRemove.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnScanFinishedDelegate(string sender = null, object data = null);
        public event OnScanFinishedDelegate OnScanFinished;
        internal void RaiseOnScanFinished(string sender = null, object data = null)
        {
            if (OnScanFinished != null)
            {
                OnScanFinished.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnScanStartedDelegate(string sender = null, object data = null);
        public event OnScanStartedDelegate OnScanStarted;
        internal void RaiseOnScanStarted(string sender = null, object data = null)
        {
            if (OnScanStarted != null)
            {
                OnScanStarted.BeginInvoke(sender, data, null, null);
            }
        }

        public delegate void OnUpdateDelegate(string sender = null, OnUpdate_data data = null);
        public event OnUpdateDelegate OnUpdate;
        internal void RaiseOnUpdate(string sender = null, OnUpdate_data data = null)
        {
            if (OnUpdate != null)
            {
                OnUpdate.BeginInvoke(sender, data, null, null);
            }
        }
    }
}
