# NHL.NET
### A .NET Standard 2.0 API wrapper for the undocumented NHL API

# Usage

# Docs

## Divisions

**GetAllAsync / GetAll**

Gets a list of currently active NHL divisions.

```
NHLDivisionList divisionList = await nhlClient.Divisions.GetAllAsync();
NHLDivisionList divisionList = nhlClient.Divisions.GetAll();
```

**GetMultipleAsync / GetMultiple**

Gets a list of specific divisions by id.

```
var divisionIds = new List<int> { 1, 2, 3 };
NHLDivisionList divisionList = await nhlClient.Divisions.GetMultipleAsync(divisionIds);
NHLDivisionList divisionList = nhlClient.Divisions.GetMultiple(divisionIds);
```

## Conferences

**GetAllAsync / GetAll**

Gets a list of currently active NHL conferences.

```
NHLConferenceList conferenceList = await nhlClient.Conferences.GetAllAsync();
NHLConferenceList conferenceList = nhlClient.Conferences.GetAll();
```

**GetMultipleAsync / GetMultiple**

Gets a list of specific conferences by id.

```
var conferenceIds = new List<int> { 1, 2, 3 };
NHLConferenceList conferenceList = await nhlClient.Conferences.GetMultipleAsync();
NHLConferenceList conferenceList = nhlClient.Conferences.GetMultiple();
```

**GetByIdAsync / GetById**

Gets a specific conference by id.

```
NHLConference conference = await nhlClient.Conferences.GetByIdAsync(1);
NHLConference conference = nhlClient.Conferences.GetById(1);
```
