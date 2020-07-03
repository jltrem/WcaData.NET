module WcaData.ApiTypes

open System

// fsharplint:disable RecordFieldNames

type Avatar = {
  url: string
  thumb_url: string
  is_default: bool
}

type Team = {

  uknown: string
}

type User = {
  ``class``: string
  url: string
  id: uint32
  wca_id: string
  name: string
  gender: string
  country_iso2: string
  delegate_status: string
  created_at: DateTime
  updated_at: DateTime
  teams: Team list
  avatar: Avatar
}

type GetUser = {
  user: User
}

type RecordTimePair = {
  single: uint32
  average: uint32
}

type GetRecords = {
  world_records: Map<string, RecordTimePair>
  continental_records: Map<string, Map<string, RecordTimePair>>
  national_records: Map<string, Map<string, RecordTimePair>>
}

type Person = {
  wca_id: string
  name: string
  url: string
  gender: string
  country_iso2: string
  delegate_status: string
  teams: Team list
  avatar: Avatar
}

type PersonalRecord = {
  best: int
  world_rank: int
  continent_rank: int
  country_rank: int
}

type PersonalRecordPair = {
  single: PersonalRecord
  average: PersonalRecord
}


type MedalCounts = {
  gold: int
  silver: int
  bronze: int
  total: int
}

type RecordCounts = {
  national: int
  continental: int
  world: int
  total: int
}

type GetPerson = {
  person: Person
  competition_count: int
  personal_records: Map<string, PersonalRecordPair>
  medals: MedalCounts
  records: RecordCounts
}

