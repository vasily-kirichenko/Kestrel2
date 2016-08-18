FROM microsoft/dotnet:1.0.0-preview2-sdk

#COPY ./src/Kestrel2/bin/Release/netcoreapp1.0/ /app
ADD ./src/Kestrel2/ /app
EXPOSE 5000
WORKDIR /app
CMD ["dotnet", "restore"]
CMD ["dotnet", "run"]