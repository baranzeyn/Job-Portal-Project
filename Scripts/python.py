import googleapiclient.discovery
import pandas as pd

api_service_name = "youtube"
api_version = "v3"
DEVELOPER_KEY = "AIzaSyD3gH2nswksqPyn8YFpulgRbMvaF3KqhuY"

youtube = googleapiclient.discovery.build(
    api_service_name, api_version, developerKey=DEVELOPER_KEY)

request = youtube.commentThreads().list(
    part="snippet",
    videoId="A_Sfru99QNA",
    maxResults=100
)
response = request.execute()

comments = []

for item in response['items']:
    comment = item['snippet']['topLevelComment']['snippet']
    comments.append([
        comment['authorDisplayName'],
        comment['publishedAt'],
        comment['updatedAt'],
        comment['likeCount'],
        comment['textDisplay']
    ])

df = pd.DataFrame(comments, columns=['author', 'published_at', 'updated_at', 'like_count', 'text'])

# Check if the file exists and delete it
excel_file_path = "comments.xlsx"
# Save the DataFrame to Excel
df.to_excel(excel_file_path, index=False)
print(f"Excel file '{excel_file_path}' created successfully.")
