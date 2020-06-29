﻿using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;

namespace Locations
{
    public class APIService
    {
        const string API_URL = "/locations";
        readonly RestClient client = new RestClient("https://localhost:44387");
        private API_User user = new API_User();

        public bool LoggedIn { get { return !string.IsNullOrWhiteSpace(user.Token); } }

        public List<Location> GetAllLocations()
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Location>> response = client.Get<List<Location>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                //response not received
               throw new Exception("An error occurred communicating with the server.");
                
            }
            else if (!response.IsSuccessful)
            {
                //response non-2xx
               throw new Exception("An error response was received from the server. The status code is " + (int)response.StatusCode);
                
            }
            else
            {
                //success
                return response.Data;
            }
        }

        public Location GetDetailsForLocation(int locationId)
        {
            RestRequest requestOne = new RestRequest(API_URL + "/" + locationId);
            if (!string.IsNullOrWhiteSpace(user.Token)) client.Authenticator = new JwtAuthenticator(user.Token);
            IRestResponse<Location> response = client.Get<Location>(requestOne);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                //response not received
               throw new Exception("An error occurred communicating with the server.");
                
            }
            else if (!response.IsSuccessful)
            {
                //response non-2xx
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                   throw new Exception("Authorization is required for this endpoint. Please log in.");
                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                   throw new Exception("You do not have permission to perform the requested action");
                else
                   throw new Exception("An error response was received from the server. The status code is " + (int)response.StatusCode);

                
            }
            else
            {
                //success
                return response.Data;
            }
        }

        public Location AddLocation(Location newLocation)
        {
            RestRequest request = new RestRequest(API_URL);
            request.AddJsonBody(newLocation);
            if (!string.IsNullOrWhiteSpace(user.Token)) client.Authenticator = new JwtAuthenticator(user.Token);
            IRestResponse<Location> response = client.Post<Location>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                //response not received
               throw new Exception("An error occurred communicating with the server.");
                
            }
            else if (!response.IsSuccessful)
            {
                //response non-2xx
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                   throw new Exception("Authorization is required for this endpoint. Please log in.");
                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                   throw new Exception("You do not have permission to perform the requested action");
                else
                   throw new Exception("An error response was received from the server. The status code is " + (int)response.StatusCode);

                
            }
            else
            {
                //success
                return response.Data;
            }
        }

        public Location UpdateLocation(Location locationToUpdate)
        {
            RestRequest request = new RestRequest(API_URL + "/" + locationToUpdate.Id);
            request.AddJsonBody(locationToUpdate);
            if (!string.IsNullOrWhiteSpace(user.Token)) client.Authenticator = new JwtAuthenticator(user.Token);
            IRestResponse<Location> response = client.Put<Location>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                //response not received
               throw new Exception("An error occurred communicating with the server.");
                
            }
            else if (!response.IsSuccessful)
            {
                //response non-2xx
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                   throw new Exception("Authorization is required for this endpoint. Please log in.");
                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                   throw new Exception("You do not have permission to perform the requested action");
                else
                   throw new Exception("An error response was received from the server. The status code is " + (int)response.StatusCode);

                
            }
            else
            {
                //success
                return response.Data;
            }
        }

        public void DeleteLocation(int locationId)
        {
            RestRequest request = new RestRequest(API_URL + "/" + locationId);
            if (!string.IsNullOrWhiteSpace(user.Token)) client.Authenticator = new JwtAuthenticator(user.Token);
            IRestResponse response = client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                //response not received
               throw new Exception("An error occurred communicating with the server.");
            }
            else if (!response.IsSuccessful)
            {
                //response non-2xx
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                   throw new Exception("Authorization is required for this endpoint. Please log in.");
                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                   throw new Exception("You do not have permission to perform the requested action");
                else
                   throw new Exception("An error response was received from the server. The status code is " + (int)response.StatusCode);
            }
            else
            {
                //success
               throw new Exception("Location successfully deleted");
            }
        }

        public bool Login(string submittedName, string submittedPass)
        {
            var credentials = new { username = submittedName, password = submittedPass }; //this gets converted to JSON by RestSharp
            RestRequest request = new RestRequest("/login");
            request.AddJsonBody(credentials);
            IRestResponse<API_User> response = client.Post<API_User>(request);

            if (response.ResponseStatus != ResponseStatus.Completed) {
               throw new Exception("An error occurred communicating with the server.");

            } else if (!response.IsSuccessful) {
                if (!string.IsNullOrWhiteSpace(response.Data.Message)) {
                   throw new Exception("An error message was received: " + response.Data.Message);
                } else {
                   throw new Exception("An error response was received from the server. The status code is " + (int)response.StatusCode);
                }
     
            } else {
                user.Token = response.Data.Token;
                client.Authenticator = new JwtAuthenticator(user.Token);
                return true;
            }
        }

        public void Logout()
        {
            user = new API_User();
            client.Authenticator = null;
        }
    }
}