using System;
using System.Collections.Generic;
using System.Text;
using VersionOne.Assets;

namespace TestAssetClient.Data
{
    class StoryManager
    {

        public List<Story> GetAll()
        {
            List<Story> storyList = new List<Story>();
            
            string instanceUrl = "https://www16.v1host.com/api-examples/api/asset";
            string accessToken = "1.bndNO51GiliELZu1bbQdq3omgRI=";
            
            var v1 = new AssetClient(instanceUrl, accessToken);

           
            var assets = v1
                .Query("Story")
               .Select("Name", "Scope", "Estimate", "Description", "Number", "IsClosed")
               .Retrieve();
           
            foreach (dynamic story in assets)
            {
                storyList.Add(new Story
                {
                    Href = story.Oid,
                    Scope = story.Scope.Oid,
                    Name = story.Name,
                    Description = story.Description,
                    Number = story.Number,
                    IsClosed = Convert.ToBoolean(story.IsClosed)
                    //Attachments
                    //Owners
                });
            }

            return storyList;
        }
    }
}
