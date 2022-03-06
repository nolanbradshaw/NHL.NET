[![Code Analysis](https://github.com/nolanbradshaw/NHL.NET/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/nolanbradshaw/NHL.NET/actions/workflows/codeql-analysis.yml)
[![Build and Test](https://github.com/nolanbradshaw/NHL.NET/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/nolanbradshaw/NHL.NET/actions/workflows/dotnet.yml)
# NHL.NET
### A .NET Standard 2.0 API wrapper for the undocumented NHL API

# Usage

**It is highly recommended you don't manually create an instance of NHLClient for every request.**

Using dependency injection
```CSharp
services.AddSingleton<INHLClient, NHLClient>();
```

# Docs
- [Teams](#teams)
- [Divisions](#divisions)
- [Conferences](#conferences)

## Teams

**GetAllAsync / GetAll**

Gets a list of currenty active NHL teams.

```CSharp
NHLTeamList teamList = await nhlClient.Teams.GetAllAsync();
NHLTeamList teamList = nhlClient.Teams.GetAll();
```

**GetMultipleAsync / GetMultiple**

Gets a list of specific teams by id.

```CSharp
var teamIds = new List<int> { 1, 2, 3 };
NHLTeamList teamList = await nhlClient.Teams.GetMultipleAsync(teamIds);
NHLTeamList teamList = nhlClient.Teams.GetMultiple(teamIds);
```

**GetByIdAsync / GetById**

Get a specific team by id.

```CSharp
NHLTeam team = await nhlClient.Teams.GetByIdAsync(5);
NHLTeam team = nhlClient.Teams.GetById(5);
```

**GetStatsAsync / GetStats**

Gets a teams stats for a given team and specific season (current season if no season is passed).

```CSharp
NHLTeamStats currentSeasonTeamStats = await nhlClient.Teams.GetStatsAsync(5);
currentSeasonTeamStats = nhlClient.Teams.GetStats(5);

NHLTeamStats specificSeasonTeamStats = await nhlClient.Teams.GetStatsAsync(5, "20102011");
specificSeasonTeamStats = nhlclient.Teams.GetStats(5, "20102011");

// Ex. 52.4
var faceOffWinPercentage = specificSeasonTeamStats.FaceoffWinPercentage;
// Ex. "14th"
var powerplayRank = currentSeasonTeamStats.PowerPlayRank;
```

For all team stats properties see: [Team Stats](NHL.NET/Models/Team/NHLTeamStats.cs)

## Divisions

**GetAllAsync / GetAll**

Gets a list of currently active NHL divisions.

```CSharp
NHLDivisionList divisionList = await nhlClient.Divisions.GetAllAsync();
NHLDivisionList divisionList = nhlClient.Divisions.GetAll();
```

**GetMultipleAsync / GetMultiple**

Gets a list of specific divisions by id.

```CSharp
var divisionIds = new List<int> { 1, 2, 3 };
NHLDivisionList divisionList = await nhlClient.Divisions.GetMultipleAsync(divisionIds);
NHLDivisionList divisionList = nhlClient.Divisions.GetMultiple(divisionIds);
```

## Conferences

**GetAllAsync / GetAll**

Gets a list of currently active NHL conferences.

```CSharp
NHLConferenceList conferenceList = await nhlClient.Conferences.GetAllAsync();
NHLConferenceList conferenceList = nhlClient.Conferences.GetAll();
```

**GetMultipleAsync / GetMultiple**

Gets a list of specific conferences by id.

```CSharp
var conferenceIds = new List<int> { 1, 2, 3 };
NHLConferenceList conferenceList = await nhlClient.Conferences.GetMultipleAsync();
NHLConferenceList conferenceList = nhlClient.Conferences.GetMultiple();
```

**GetByIdAsync / GetById**

Gets a specific conference by id.

```CSharp
NHLConference conference = await nhlClient.Conferences.GetByIdAsync(1);
NHLConference conference = nhlClient.Conferences.GetById(1);
```
